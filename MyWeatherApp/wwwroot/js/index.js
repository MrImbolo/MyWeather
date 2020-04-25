document.addEventListener("DOMContentLoaded", function () {
    const searchBtn = document.getElementById("searchBtn");
    searchBtn.addEventListener("click", async function() {
        const searchStr = document.getElementById("locationName");
        let result = await fetchAsync(`/locations?name=${searchStr}`, "POST");

        const tablist = document.getElementById('list-locations');

        // <a class="list-group-item list-group-item-action" id="list-home-list" data-toggle="list" href="#list-home" role="tab" aria-controls="home">Home</a>
        let item = document.createElement("a");
        item.classList.add('list-group-item', 'list-group-item-action');
        item.attributes.setNamedItem('data-toggle', 'list');
        item.attributes.setNamedItem('role', 'tab');
        

        result.forEach(location => {
            let clone = item.cloneNode();
            clone.id = `location_${location.id}`;
            clone.attributes.setNamedItem('data-id', location.id);
            clone.addEventListener('click', handleFoundCity);
        });

        async function handleFoundCity(e) {
            const link = e.target;

            await fetchAsync('/location/', "PUT", { locationId: parseInt(link.attributes.getNamedItem("data-id")) });
        }
    });
})