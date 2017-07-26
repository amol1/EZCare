ezConnectWebapp.controller('ParentController', function ($scope, $http) {
    $scope.Children = [];
    $scope.errored = false;

    $scope.fetchParent = function () {
        $http.get("/api/parent/1").success(function (data, status, headers, config) {
            debugger;
            $scope.Children = data.children;
            $scope.errored = false;
        }).error(function (data, status, headers, config) {
            $scope.errored = true;
        });
    };
});