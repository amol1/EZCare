ezConnectWebapp.config(['$routeProvider',
    function ($routeProvider) {
        $routeProvider.
            when('/parent', {
                templateUrl: '/app/partials/ParentView.html',
                controller: 'ParentController'
            }).
            when('/child', {
                templateUrl: '/app/partials/ChildView.html',
                controller: 'ChildController'
            }).
            otherwise({
                redirectTo: '/parent'
            })
    }
]);
