'use strict';
app.factory('mainService', ['$http', '$route', function ($http, $route) {

    var mainServiceFactory = {};

    var _getTemplate = function () {
        return $http.get('/api/main').then(function (results) {
            return results;
        });
    };

    var _saveTemplate = function (model) {
        return $http.post('/api/main/save', model).then(function (results) {
            return results;
        });
    };

    mainServiceFactory.getTemplate = _getTemplate;

    mainServiceFactory.saveTemplate = _saveTemplate;

    return mainServiceFactory;

}]);