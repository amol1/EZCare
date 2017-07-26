ezConnectWebapp.controller('ChildController', function ($scope, $http) {
    $scope.Id = "";
    $scope.Name = "";
    $scope.Age = "";
    $scope.Condition = "";
    $scope.Appointments = [];
    $scope.errored = false;

    $scope.fetchChild = function () {
        $http.get("/api/child/Child1").success(function (data, status, headers, config) {
            debugger;
            $scope.Id = data.id;
            $scope.Name = data.name;
            $scope.Age = data.age;
            $scope.Condition = data.condition;
            $scope.Appointments = data.appointments;
            $scope.errored = false;
        }).error(function (data, status, headers, config) {
            $scope.errored = true;
        });
    };
});