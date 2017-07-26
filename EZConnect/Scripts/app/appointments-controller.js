angular.module('EZConnectWebApp', [])
    .controller('AppointmentCtrl', function ($scope, $http) {
        $scope.child = false;
        $scope.Provider = "";
        $scope.AppointmentTime = "";

        $scope.answer = function () {
            return $scope.correctAnswer ? 'correct' : 'incorrect';
        };
    });
