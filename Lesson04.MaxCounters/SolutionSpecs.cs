using Machine.Specifications;

namespace Lesson04.MaxCounters
{
    [Subject(typeof(Solution))]
    public class SolutionSpecs
    {
        Because of = () => 
            _result = _solution.solution(N, A);

        public class happy_path
        {
            Establish context = () =>
            {
                N = 5;
                A = new[] {3, 4, 4, 6, 1, 4, 4};
            };

            It should_return_the_expected_result = () =>
                _result.ShouldEqual(new [] {3, 2, 2, 4, 2});
        }

        public class When_N_and_M_and_the_unique_value_are_equal_to_1
        {
            Establish context = () =>
            {
                N = 1;
                A = new[] {1};
            };

            It should_return_the_expected_result = () =>
                _result.ShouldEqual(new [] {1});
        }

        public class When_N_and_M_and_are_equal_to_1_but_the_unique_value_is_2
        {
            Establish context = () =>
            {
                N = 1;
                A = new[] {2};
            };

            It should_return_the_expected_result = () =>
                _result.ShouldEqual(new [] {0});
        }

        public class When_N_is_greather_than_M
        {
            Establish context = () =>
            {
                N = 10;
                A = new[] { 3, 4, 4, 6, 1, 4, 4 };
            };

            It should_return_the_expected_result = () =>
                _result.ShouldEqual(new[] { 1, 0, 1, 4, 0, 1, 0, 0, 0, 0 });
        }

        public class When_all_the_values_are_equal_to_N_plus_1
        {
            Establish context = () =>
            {
                N = 7;
                A = new[] { 8, 8, 8, 8, 8, 8, 8 };
            };

            It should_return_the_expected_result = () =>
                _result.ShouldEqual(new[] { 0, 0, 0, 0, 0, 0, 0 });
        }

        public class When_N_and_M_are_the_maximum_possible_and_all_values_are_1
        {
            Establish context = () =>
            {
                N = 100000;
                A = new int[100000];
                for (int i = 0; i < 100000; i++)
                    A[i] = 1;
            };

            It should_return_an_array_with_length_equal_to_N = () =>
                _result.Length.ShouldEqual(N);

            It should_has_the_first_value_be_equal_to_N = () =>
                _result[0].ShouldEqual(N);

            It should_has_the_value_0_in_all_the_elements_but_the_first = () =>
            {
                for (int i = 1; i < N; i++)
                    _result[i].ShouldEqual(0);
            };
        }

        public class When_N_and_M_are_the_maximum_possible_and_all_values_are_equal_to_N
        {
            Establish context = () =>
            {
                N = 100000;
                A = new int[100000];
                for (int i = 0; i < 100000; i++)
                    A[i] = N;
            };

            It should_return_an_array_with_length_equal_to_N = () =>
                _result.Length.ShouldEqual(N);

            It should_has_the_last_value_be_equal_to_N = () =>
                _result[N - 1].ShouldEqual(N);

            It should_has_the_value_0_in_all_the_elements_but_the_last = () =>
            {
                for (int i = 0; i < N - 1; i++)
                    _result[i].ShouldEqual(0);
            };
        }

        public class When_N_and_M_are_the_maximum_possible_and_all_values_are_equal_to_N_plus_1
        {
            Establish context = () =>
            {
                N = 100000;
                A = new int[100000];
                for (int i = 0; i < 100000; i++)
                    A[i] = N + 1;
            };

            It should_return_an_array_with_length_equal_to_N = () =>
                _result.Length.ShouldEqual(N);

            It should_has_the_value_0_in_all_the_elements = () =>
            {
                for (int i = 0; i < N; i++)
                    _result[i].ShouldEqual(0);
            };
        }

        static Solution _solution = new Solution();
        static int N;
        static int[] _result;
        static int[] A;
    }
}