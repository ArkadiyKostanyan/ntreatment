app.controller('mainController', ['$scope', '$route', '$location', 'mainService', function ($scope, $route, $location, mainService) {

    $scope.model = {};
    $scope.user = {
        Name: 'Denis Ryabukha',
        Id: '0000-0000-0000-0001',
        Date: new Date()
    }
    $scope.isPreview = false;
    $scope.showHtml = false;

    $scope.getTemplate = function () {
        if ($location.path() == '/preview') {
            $scope.isPreview = true;
        }
        mainService.getTemplate().then(function (response) {
                $scope.model = response.data;
            }, function (response) {
                console.log(response);
                alert("Error occured. Open please console for details.")
            });
    };

    $scope.saveTemplate = function () {

        //var html = $("#modelHtml").html(); //if you whant send html to server

        mainService.saveTemplate($scope.model).then(function (response) {
            $scope.message = response.data.substr(1, response.data.length - 2);
            alert("Template have been saved.")
            $location.path('/preview');
        }, function (response) {
                var errors = [];
                for (var key in response.data.modelState) {
                    for (var i = 0; i < response.data.modelState[key].length; i++) {
                        errors.push(response.data.modelState[key][i]);
                    }
                }
                $scope.messageAdd = errors.join(' ');
                if ($scope.messageAdd == '') {
                    $scope.messageAdd = response.data.message;
                }
                $scope.message = '';
            });
    };
}]);