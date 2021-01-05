// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
async function fetchAsync(url, method, object) {
    let request = {
        headers: {
            "Content-Type": "application/json;charset=utf-8"
        },
    }

    if (!!method)
        request.method = method;
    else
        request.method = 'GET';

    if (!!object) request.body = JSON.stringify(object);

    const RESPONSE = await fetch(url, request);

    if (RESPONSE.ok) {
        const CONTENT_TYPE = RESPONSE.headers.get("Content-Type");
        if (CONTENT_TYPE.includes("application/json")) {
            try {
                let result = await RESPONSE.json();
                console.log(result);
                return result;
            }
            catch (error) {
                console.error("Error! Unable to parse json:" + error);
                return {
                    status: 'error',
                    error: `Json parse error: ${error}`
                }
            }
        }
        else if (CONTENT_TYPE.includes("text/html") || CONTENT_TYPE.includes("text/plain")) {
            try {
                return await RESPONSE.text();
            }
            catch (error) {
                console.error("Error! Unable to parse text:" + error);
                return {
                    status: 'error',
                    error: `Text read error: ${error}`
                }
            }
        }
        else {
            console.error("Error! Unknown response mime type:" + error);
            return {
                status: 'error',
                error: `No handler specified for MIME ${CONTENT_TYPE}`
            }
        }
    }
    else {
        return {
            status: 'error',
            response: RESPONSE
        }
    }
}