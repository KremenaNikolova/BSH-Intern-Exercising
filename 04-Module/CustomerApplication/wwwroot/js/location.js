document.addEventListener("DOMContentLoaded", function () {
    const countrySelect = document.getElementById("country");
    const citySelect = document.getElementById("city");

    function loadCountries() {
        fetch("https://api.npoint.io/66866aef2c21692fe055")
            .then((response) => response.json())
            .then((data) => {
                data.forEach((country) => {
                    const option = new Option(country.country, country.country);
                    countrySelect.appendChild(option);
                });
            })
            .catch((error) => console.error("Error:", error));
    }

    function loadCities() {
        const selectedCountry = countrySelect.value;
        citySelect.innerHTML = "";

        fetch("https://api.npoint.io/66866aef2c21692fe055")
            .then((response) => response.json())
            .then((data) => {
                const country = data.find(
                    (country) => country.country === selectedCountry
                );
                if (country) {
                    country.cities.forEach((city) => {
                        const option = new Option(city, city);
                        citySelect.appendChild(option);
                    });
                }
            })
            .catch((error) => console.error("Error:", error));
    }

    loadCountries();

    countrySelect.addEventListener("change", loadCities);
});