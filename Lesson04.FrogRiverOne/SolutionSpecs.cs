using Machine.Specifications;

namespace Lesson04.FrogRiverOne
{
    [Subject(typeof(Solution))]
    public class SolutionSpecs
    {
        Because of = () => 
            _result = _solution.solution(_stepsNeeded, _array);

        public class When_X_equal_to_1_the_unique_element_in_the_array_is_1
        {
            Establish context = () =>
            {
                _stepsNeeded = 1;
                _array = new[] {1};
            };

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        public class When_X_equal_to_1_but_the_unique_element_in_the_array_is_grather_than_1
        {
            Establish context = () =>
            {
                _stepsNeeded = 1;
                _array = new[] {2};
            };

            It should_return_minus_1 = () =>
                _result.ShouldEqual(-1);
        }

        public class When_the_number_of_elements_of_the_array_is_minor_to_X
        {
            Establish context = () =>
            {
                _stepsNeeded = 2;
                _array = new[] {1};
            };

            It should_return_minus_1 = () =>
                _result.ShouldEqual(-1);
        }

        public class When_the_array_has_exactly_the_required_steps_and_ordered
        {
            Establish context = () =>
            {
                _stepsNeeded = 5;
                _array = new[] {1, 2, 3, 4, 5};
            };

            It should_return_the_right_result = () =>
                _result.ShouldEqual(4);
        }

        public class When_the_array_has_exactly_the_required_steps_but_unordered
        {
            Establish context = () =>
            {
                _stepsNeeded = 5;
                _array = new[] {5, 2, 4, 1, 3};
            };

            It should_return_the_right_result = () =>
                _result.ShouldEqual(4);
        }

        public class When_path_is_filled_after_some_redundancy_in_leaves
        {
            Establish context = () =>
            {
                _stepsNeeded = 5;
                _array = new[] {1, 3, 1, 4, 2, 3, 5, 4};
            };

            It should_return_the_right_result = () =>
                _result.ShouldEqual(6);
        }

        public class When_the_path_is_not_completed_with_several_provided_options
        {
            Establish context = () =>
            {
                _stepsNeeded = 5;
                _array = new[] { 5, 2, 1, 3 };
            };

            It should_return_minus_1 = () =>
                _result.ShouldEqual(-1);
        }

        public class When_it_presents_the_most_valid_extremme_case
        {
            Establish context = () =>
            {
                _stepsNeeded = 100000;
                _array = new int[100000];
                for (int i = 0; i < _array.Length - 1; i++)
                    _array[i] = 100000 - i;
                _array[_array.Length - 1] = 1;
            };

            It should_return_the_right_result = () =>
                _result.ShouldEqual(100000 - 1);
        }

        public class When_it_presents_the_most_invalid_extremme_case
        {
            Establish context = () =>
            {
                _stepsNeeded = 100000;
                _array = new int[100000];
                for (int index = 0; index < _array.Length; index++)
                    _array[index] = 100000;
            };

            It should_return_the_right_result = () =>
                _result.ShouldEqual(-1);
        }

        static Solution _solution = new Solution();
        static int _result;
        static int _stepsNeeded;
        static int[] _array;
    }
}