using Machine.Specifications;

namespace Lesson01.BinaryGap
{
    [Subject(typeof(Solution))]
    public class SolutionSpecs
    {
        Because of = () =>
            _result = _solution.solution(_number);

        public class When_the_binary_has_no_zeros
        {
            Establish context = () => 
                _number = 1;

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        public class When_the_binary_has_one_zero_but_its_not_close_by_ones
        {
            Establish context = () => 
                _number = 2;

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        public class When_the_binary_has_one_binary_gap
        {
            Establish context = () => 
                _number = 9;

            It should_return_the_right_result = () =>
                _result.ShouldEqual(2);
        }

        public class When_the_binary_has_two_binary_gaps
        {
            Establish context = () => 
                _number = 1041;

            It should_return_the_maximum_binary_gap = () =>
                _result.ShouldEqual(5);
        }

        public class When_the_binary_its_from_the_maximum_integer
        {
            Establish context = () => 
                _number = 2147483647;

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        static Solution _solution = new Solution();
        static int _result;
        static int _number;
    }
}