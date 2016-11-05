using Machine.Specifications;

namespace Lesson04.MissingInteger
{
    [Subject(typeof(Solution))]
    public class SolutionSpecs
    {
        Because of = () => 
            _result = _solution.solution(_array);

        public class When_the_unique_element_in_the_array_is_the_minimal_negative_possible
        {
            Establish context = () => 
                _array = new [] { -2147483648 };

            It should_return_1 = () =>
                _result.ShouldEqual(1);
        }

        public class When_the_unique_element_in_the_array_is_the_maximum_negative_possible
        {
            Establish context = () => 
                _array = new [] { -1 };

            It should_return_1 = () =>
                _result.ShouldEqual(1);
        }

        public class When_the_unique_element_in_the_array_is_0
        {
            Establish context = () => 
                _array = new [] { 0 };

            It should_return_1 = () =>
                _result.ShouldEqual(1);
        }

        public class When_the_unique_element_in_the_array_is_the_minimal_positive_possible
        {
            Establish context = () => 
                _array = new [] { 1 };

            It should_return_2 = () =>
                _result.ShouldEqual(2);
        }

        public class When_the_unique_element_in_the_array_is_the_maximum_positive_possible
        {
            Establish context = () => 
                _array = new [] { 2147483647 };

            It should_return_1 = () =>
                _result.ShouldEqual(1);
        }

        public class When_the_array_is_a_perfect_sequence_of_the_first_positive_numbers
        {
            Establish context = () => 
                _array = new [] { 1, 2, 3, 4, 5 };

            It should_return_the_right_result = () =>
                _result.ShouldEqual(6);
        }

        public class When_the_array_contains_the_first_positive_numbers_unordered
        {
            Establish context = () => 
                _array = new [] { 1, 5, 3, 4, 2 };

            It should_return_the_right_result = () =>
                _result.ShouldEqual(6);
        }

        public class When_the_array_miss_some_positive_number
        {
            Establish context = () => 
                _array = new [] { 1, 3, 6, 4, 1, 2 };

            It should_return_the_right_result = () =>
                _result.ShouldEqual(5);
        }

        public class When_the_array_has_the_maximum_number_of_elements_with_the_maximum_positive_values
        {
            Establish context = () =>
            {
                _array = new int[100000];
                for (int i = 0; i < _array.Length; i++)
                    _array[i] = -2147483647;
            };

            It should_return_the_right_result = () =>
                _result.ShouldEqual(1);
        }

        public class When_the_array_has_the_maximum_number_of_elements_with_the_maximum_negative_values
        {
            Establish context = () =>
            {
                _array = new int[100000];
                for (int i = 0; i < _array.Length; i++)
                    _array[i] = -2147483648;
            };

            It should_return_the_right_result = () =>
                _result.ShouldEqual(1);
        }

        static Solution _solution = new Solution();
        static int _result;
        static int[] _array;
    }
}