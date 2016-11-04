using Machine.Specifications;

namespace Lesson03.FrogJmp
{
    [Subject(typeof(Solution))]
    public class SolutionSpecs
    {
        Because of = () => 
            _result = _solution.solution(_initialPosition, _targetPosition, _fixedDistance);

        public class When_the_target_position_is_equal_to_the_start
        {
            Establish context = () =>
            {
                _initialPosition = 1;
                _targetPosition = _initialPosition;
                _fixedDistance = _anyDistance;
            };

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        public class When_the_distance_between_the_start_and_the_target_is_equal_to_jump_distance
        {
            Establish context = () =>
            {
                _initialPosition = 1;
                _targetPosition = 2;
                _fixedDistance = 1;
            };

            It should_return_1 = () =>
                _result.ShouldEqual(1);
        }

        public class When_the_distance_between_the_start_and_the_target_is_multiplier_of_jump_distance
        {
            Establish context = () =>
            {
                _initialPosition = 2;
                _targetPosition = 10;
                _fixedDistance = 2;
            };

            It should_return_the_right_result = () =>
                _result.ShouldEqual(4);
        }

        public class When_the_distance_between_the_start_and_the_target_is_multiplier_of_jump_distance_plus_1
        {
            Establish context = () =>
            {
                _initialPosition = 2;
                _targetPosition = 11;
                _fixedDistance = 2;
            };

            It should_return_the_right_result = () =>
                _result.ShouldEqual(5);
        }

        public class When_the_distance_between_the_start_and_the_target_is_multiplier_of_jump_distance_minus_1
        {
            Establish context = () =>
            {
                _initialPosition = 1;
                _targetPosition = 9;
                _fixedDistance = 3;
            };

            It should_return_the_right_result = () =>
                _result.ShouldEqual(3);
        }

        public class When_the_jump_distance_is_greather_than_the_distance_between_the_start_and_the_target
        {
            Establish context = () =>
            {
                _initialPosition = 1;
                _targetPosition = 9;
                _fixedDistance = 9;
            };

            It should_return_1 = () =>
                _result.ShouldEqual(1);
        }

        public class When_its_necessary_to_do_the_maximum_possible_number_of_jumps
        {
            Establish context = () =>
            {
                _initialPosition = 1;
                _targetPosition = 1000000000;
                _fixedDistance = 1;
            };

            It should_return_the_right_result = () =>
                _result.ShouldEqual(1000000000 - 1);
        }

        static Solution _solution = new Solution();
        static int _result;
        static int _anyDistance = 1;
        static int _initialPosition;
        static int _targetPosition;
        static int _fixedDistance;
    }
}