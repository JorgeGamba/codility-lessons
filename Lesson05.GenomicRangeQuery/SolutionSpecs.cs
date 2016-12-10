using Machine.Specifications;

namespace Lesson05.GenomicRangeQuery
{
    [Subject(typeof(Solution))]
    public class SolutionSpecs
    {
        Because of = () =>
            _result = _solution.solution(S, P, Q);

        public class on_provided_example
        {
            Establish context = () =>
            {
                S = "CAGCCTA";
                P = new [] {2, 5, 0};
                Q = new [] {4, 5, 6};
            };

            It should_return_the_expected_result = () =>
                _result.ShouldEqual(new []{2, 4, 1});
        }

        static Solution _solution = new Solution();
        static string S;
        static int[] P, Q;
        static int[] _result;
    }
}