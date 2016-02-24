app.directive("pid", function () {

    return {
        restrict: 'E',
        templateUrl: "/partials/PID-5.html",
        scope: {
            User: '=user'
        },
        controller: function ($http, $scope) {

            $scope.checkedCount = 0;

            $scope.model = {
                Reckless: null,
                OnImpulse : null,
                RashDecisions : null,
                NothingIDo : null,
                Irresponsible : null,
                PlanningAhead : null,
                Thoughts: null,
                WorryEverything: null,
                EmotionalEasily: null,
                FearBeingAlone: null,
                GetStuckOnOneWay: null,
                ThingsThatNotReally: null,
                RomanticRelationships: null,
                MakingFriends: null,
                IrritatedEasily: null,
                CloseToPeople: null,
                HurtOther: null,
                Enthusiastic: null,
                CraveAttention: null,
                DealLessImportant: null,
                ThoughtsMakeSense: null,
                GetWhatIWant: null,
                ZoneOut: null,
                ThingsUnreal: null,
                TakeAdvantage: null,
                AvarageTotalScore: null,
                TotalScore: null,
                ProratedTotalScore:null
            };

            $scope.AvarageTotalScore = function () {
                $scope.model.AvarageTotalScore = $scope.model.TotalScore / 25;
            }

            $scope.ProratedTotalScore = function () {
                if($scope.checkedCount <= 0)
                {
                    $scope.model.ProratedTotalScore = null;
                }
                else{
                    $scope.model.ProratedTotalScore = $scope.model.TotalScore * 25 / $scope.checkedCount;
                }
            }

            $scope.TotalScore = function () {
                $scope.model.TotalScore =
                    $scope.model.Reckless +
                    $scope.model.OnImpulse +
                    $scope.model.RashDecisions +
                    $scope.model.NothingIDo +
                    $scope.model.Irresponsible +
                    $scope.model.PlanningAhead +
                    $scope.model.Thoughts +
                    $scope.model.WorryEverything +
                    $scope.model.EmotionalEasily +
                    $scope.model.FearBeingAlone +
                    $scope.model.GetStuckOnOneWay +
                    $scope.model.ThingsThatNotReally +
                    $scope.model.RomanticRelationships +
                    $scope.model.MakingFriends +
                    $scope.model.IrritatedEasily +
                    $scope.model.CloseToPeople +
                    $scope.model.HurtOther +
                    $scope.model.Enthusiastic +
                    $scope.model.CraveAttention +
                    $scope.model.DealLessImportant +
                    $scope.model.ThoughtsMakeSense +
                    $scope.model.GetWhatIWant +
                    $scope.model.ZoneOut +
                    $scope.model.ThingsUnreal +
                    $scope.model.TakeAdvantage;
            }


            $scope.$watchCollection('model', function (item) {
                $scope.AvarageTotalScore();
                $scope.TotalScore();
                $scope.ProratedTotalScore();
            });

            $scope.Check = function (isEmpty)
            {
                if(isEmpty)
                {
                    $scope.checkedCount = $scope.checkedCount + 1;
                }
            }

            $scope.Cleare = function () {
                $scope.checkedCount = $scope.checkedCount - 1;
            }

            $scope.savePIDTemplate = function () {
                $http.post("/api/main/savePID", $scope.model)
                .then(function (response) {
                    $scope.message = response.data.substr(1, response.data.length - 2);
                    alert("PID Template have been saved.")
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
            }
        }
    }
});