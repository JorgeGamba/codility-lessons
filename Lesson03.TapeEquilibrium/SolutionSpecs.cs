using Machine.Specifications;

namespace Lesson03.TapeEquilibrium
{
    [Subject(typeof(Solution))]
    public class SolutionSpecs
    {
        Because of = () => 
            _result = _solution.solution(_array);

        public class When_the_array_has_just_two_elements
        {
            Establish context = () =>
                _array = new []{ 3, 1 };

            It should_return_2 = () =>
                _result.ShouldEqual(2);
        }

        public class When_the_left_sum_is_minor_than_the_right
        {
            Establish context = () =>
                _array = new []{ 1, 3 };

            It should_return_the_right_result = () =>
                _result.ShouldEqual(2);
        }

        public class When_just_the_left_sum_is_negative
        {
            Establish context = () =>
                _array = new[] { -1, 3 };

            It should_return_the_right_result = () =>
                _result.ShouldEqual(4);
        }

        public class When_just_the_right_sum_is_negative
        {
            Establish context = () =>
                _array = new[] { 1, -3 };

            It should_return_the_right_result = () =>
                _result.ShouldEqual(4);
        }

        public class When_both_sums_are_negative
        {
            Establish context = () =>
                _array = new[] { -1, -3 };

            It should_return_the_right_result = () =>
                _result.ShouldEqual(2);
        }

        public class When_has_more_than_one_difference
        {
            Establish context = () =>
                _array = new[] { -1, 5, -3 };

            It should_return_the_ninimum_difference = () =>
                _result.ShouldEqual(3);
        }

        public class When_the_array_has_the_maximum_number_of_elements_and_each_one_is_the_maximum_positive_value
        {
            Establish context = () =>
            {
                _array = new int[100000];
                for (int i = 0; i < 100000; i++)
                    _array[i] = 1000;
            };

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        public class When_the_array_has_the_maximum_number_of_elements_and_each_one_is_the_minimum_negative_value
        {
            Establish context = () =>
            {
                _array = new int[100000];
                for (int i = 0; i < 100000; i++)
                    _array[i] = -1000;
            };

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        static Solution _solution = new Solution();
        static int[] _array;
        static int _result;
    }
}