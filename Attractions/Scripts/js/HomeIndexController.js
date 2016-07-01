﻿//HomeIndexController.js

(function() {

    "use strict";

    angular.module("app")
        .controller("HomeIndexController", homeIndexController);

    function homeIndexController($scope, $http) {

        $scope.Attractions = [];
        $scope.Featured = [];
        $scope.Favourites = [];

        $scope.ready = false;


        $scope.addToFavourites = function() {
            //TODO
            $scope.Favourites.push(this.attraction);
            console.log(this.attraction);
        }

        $http.get("/api/v1/attractions?featured=true")
            .then(function (response) {
                // Success
                angular.copy(response.data, $scope.Featured);
                $scope.ready = true;
            }, function () {
                // Failure
            });

        $http.get("/api/v1/attractions")
            .then(function (response) {
                // Success
                angular.copy(response.data, $scope.Attractions);
            }, function () {
                // Failure
            });

        $scope.breakpoints = [
            {
                breakpoint: 1024,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 3
                }
            },
            {
                breakpoint: 650,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ];


    }

})();
