using Machine.Specifications;

namespace Lesson05.MinAvgTwoSlice
{
    [Subject(typeof(Solution))]
    public class SolutionSpecs
    {
        Because of = () =>
            _result = _solution.solution(A);

        public class on_provided_example
        {
            Establish context = () =>
                A = new [] {4, 2, 2, 5, 1, 5, 8};

            It should_return_the_expected_result = () =>
                _result.ShouldEqual(1);
        }

        public class When_all_elements_have_the_same_value
        {
            Establish context = () =>
                A = new [] {4, 4, 4, 4, 4};

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        public class When_the_array_is_a_sequence
        {
            Establish context = () =>
                A = new [] {-2, -1, 0, 1, 2, 3};

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        public class When_the_array_is_an_inverse_sequence
        {
            Establish context = () =>
                A = new [] {3, 2, 1, 0, -1, -2};

            It should_return_the_expected_result = () =>
                _result.ShouldEqual(4);
        }

        public class When_the_best_slice_has_3_elements
        {
            Establish context = () =>
                A = new [] {3, 2, -10, 0, -1, -2};

            It should_return_the_expected_result = () =>
                _result.ShouldEqual(2);
        }

        public class When_two_slices_produce_the_same_int_average_but_not_the_real
        {
            Establish context = () =>
                A = new [] {1, 0, 0};

            It should_choose_the_minor_real_division_result = () =>
                _result.ShouldEqual(1);
        }

        public class When_it_produces_the_most_extreme_case
        {
            private Establish context = () =>
            {
                A = new int[100000];
                for (int i = 0; i < 100000; i++)
                    A[i] = i % 20001 - 10000;
            };

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        static Solution _solution = new Solution();
        static int[] A;
        static int _result;
    }
}