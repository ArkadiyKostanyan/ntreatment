var app = angular.module('TemplateApp', ['ngAnimate', 'ngAria', 'ngMessages', 'ngCookies', 'ngRoute', 'ngSanitize', 'ngMaterial']);

app.config(function ($routeProvider, $locationProvider, $provide) {

    //------------------------Preview page------------------------------//
    $routeProvider.when("/preview", {
        controller: "mainController",
        templateUrl: "/partials/Edit.html"
    })
    //------------------------Preview page end---------------------------//
    //------------------------Edit page------------------------------//
    $routeProvider.when("/edit", {
        controller: "mainController",
        templateUrl: "/partials/Edit.html"
    });
    //------------------------Edit page end---------------------------//

    $routeProvider.otherwise({ redirectTo: "/preview" });

    $locationProvider.html5Mode(true);
});
