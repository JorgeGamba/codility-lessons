using Machine.Specifications;

namespace Lesson04.PermCheck
{
    [Subject(typeof(Solution))]
    public class SolutionSpecs
    {
        Because of = () => 
            _result = _solution.solution(_array);

        public class When_the_array_contains_just_a_1
        {
            Establish context = () =>
                _array = new[] {1};

            It should_return_1 = () =>
                _result.ShouldEqual(1);
        }

        public class When_the_array_contains_just_a_number_greather_than_1
        {
            Establish context = () =>
                _array = new[] {5};

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        public class When_the_array_contains_more_than_one_element_already_ordered
        {
            Establish context = () =>
                _array = new[] { 1, 2 };

            It should_return_1 = () =>
                _result.ShouldEqual(1);
        }

        public class When_the_array_contains_more_than_one_element_unordered
        {
            Establish context = () =>
                _array = new[] { 4, 1, 3, 2 };

            It should_return_1 = () =>
                _result.ShouldEqual(1);
        }

        public class When_the_array_miss_one_element_to_be_considered_a_permutation
        {
            Establish context = () =>
                _array = new[] { 4, 1, 3 };

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        public class When_the_values_sums_the_expected_amount_but_it_has_duplicated_values
        {
            Establish context = () =>
                _array = new[] { 4, 1, 4, 1 };

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        public class When_the_array_uses_the_maximums_for_N_and_values
        {
            Establish context = () =>
            {
                _array = new int[100000];
                for (int i = 0; i < 100000; i++)
                    _array[i] = 1000000000;
            };

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        static Solution _solution = new Solution();
        static int _result;
        static int[] _array;
    }
}