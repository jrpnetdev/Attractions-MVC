//DataService.js

(function() {

    "use strict";

    angular.module("app").factory("dataService", dataService);

    function dataService($http) {

        var attractions = [];
        var featured = [];
        var favourites = [];
        
        return {
            getAllAttractions: getAllAttractions,
            getFeaturedAttractions: getFeaturedAttractions,
            findAttractions: findAttractions,
            findAttractionById: findAttractionById,
            findAttractionsInContinent: findAttractionsInContinent,
            getFavourites: getFavourites,
            addToFavourites: addToFavourites
        }

        
        function getAllAttractions() {

            return $http.get("/api/v1/attractions");
        }


        function getFeaturedAttractions() {
            
            $http.get("/api/v1/featured")
                .then(function (response) {
                    // Success
                    angular.copy(response.data, featured);
                }, function () {
                    // Failure
            });
            return featured;
        }

        function findAttractions(searchText) {

            $http.get("/api/v1/attractions?searchText=" + searchText)
                .then(function (response) {
                    // Success
                    angular.copy(response.data, attractions);
                }, function () {
                    // Failure
                });
            return attractions;
        }

        function findAttractionById(id) {
            return $http.get("/api/v1/attractions?id=" + id);
        }

        function findAttractionsInContinent(continent) {

            $http.get("/api/v1/attractions?id=1&continent=" + continent)
                .then(function (response) {
                    // Success
                    angular.copy(response.data, attractions);
                }, function () {
                    // Failure
                });
            return attractions;
        }

        function getFavourites() {

            $http.get("/api/v1/favourites")
                .then(function (response) {
                    // Success
                    angular.copy(response.data, favourites);
                }, function () {
                    // Failure
            });
            return favourites;
        }

        function addToFavourites(id) {
            return $http.post("/api/v1/favourites/" + id);
        }
    }

})();