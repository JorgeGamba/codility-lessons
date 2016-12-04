using Machine.Specifications;

namespace Lesson05.CountDiv
{
    [Subject(typeof(Solution))]
    public class SolutionSpecs
    {
        Because of = () =>
            _result = _solution.solution(A, B, K);

        public class on_happy_path
        {
            Establish context = () =>
            {
                A = 6;
                B = 11;
                K = 2;
            };

            It should_return_the_expected_result = () =>
                _result.ShouldEqual(3);
        }

        public class when_A_is_equal_to_0
        {
            Establish context = () =>
            {
                A = 0;
                K = 2;
            };

            public class When_A_and_B_are_equal_to_0
            {
                Establish context = () =>
                    B = 0;

                It should_return_1 = () =>
                    _result.ShouldEqual(1);
            }

            public class When_A_is_equal_to_0_and_B_is_equal_to_K
            {
                Establish context = () =>
                    B = K;

                It should_return_1 = () =>
                    _result.ShouldEqual(2);
            }

            public class When_A_is_equal_to_0_and_B_is_equal_to_1
            {
                Establish context = () =>
                    B = 1;

                It should_return_1 = () =>
                    _result.ShouldEqual(1);
            }

            public class When_A_is_equal_to_0_and_B_is_equal_to_K_minus_1
            {
                Establish context = () =>
                    B = K - 1;

                It should_return_1 = () =>
                    _result.ShouldEqual(1);
            }

            public class When_A_is_equal_to_0_and_B_is_equal_to_a_multiplie_of_K
            {
                Establish context = () =>
                    B = K * 3;

                It should_return_the_quantity_plus_1 = () =>
                    _result.ShouldEqual(3 + 1);
            }

            public class When_A_is_equal_to_0_and_B_is_equal_to_a_multiplie_of_K_plus_1
            {
                Establish context = () =>
                    B = K * 3 + 1;

                It should_return_the_quantity_plus_1 = () =>
                    _result.ShouldEqual(3 + 1);
            }

            public class When_A_is_equal_to_0_and_B_is_equal_to_a_multiplie_of_K_minus_1
            {
                Establish context = () =>
                    B = K * 3 - 1;

                It should_return_the_quantity = () =>
                    _result.ShouldEqual(3);
            }
        }

        public class when_A_and_B_and_K_have_the_same_value
        {
            Establish context = () =>
            {
                A = 5;
                B = 5;
                K = 5;
            };

            It should_return_the_expected_result = () =>
                _result.ShouldEqual(1);
        }

        public class when_A_and_B_have_the_same_value_and_K_is_1
        {
            Establish context = () =>
            {
                A = 5;
                B = 5;
                K = 1;
            };

            It should_return_the_expected_result = () =>
                _result.ShouldEqual(1);
        }

        public class when_the_range_does_not_contain_divisible_numbers
        {
            Establish context = () =>
            {
                A = 6;
                B = 9;
                K = 5;
            };

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        public class when_the_limits_of_the_range_are_divisible_numbers
        {
            Establish context = () =>
            {
                A = 5;
                B = 10;
                K = 5;
            };

            It should_count_both_limits = () =>
                _result.ShouldEqual(2);
        }

        public class when_only_the_first_limit_of_the_range_is_a_divisible_number
        {
            Establish context = () =>
            {
                A = 5;
                B = 9;
                K = 5;
            };

            It should_only_count_the_first_limit = () =>
                _result.ShouldEqual(1);
        }

        public class when_only_the_last_limit_of_the_range_is_a_divisible_number
        {
            Establish context = () =>
            {
                A = 6;
                B = 10;
                K = 5;
            };

            It should_only_count_the_last_limit = () =>
                _result.ShouldEqual(1);
        }

        static Solution _solution = new Solution();
        static int A, B, K;
        static int _result;
    }
}