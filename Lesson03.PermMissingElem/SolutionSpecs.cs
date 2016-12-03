using Machine.Specifications;

namespace Lesson03.PermMissingElem
{
    [Subject(typeof(Solution))]
    public class SolutionSpecs
    {
        Because of = () => 
            _result = _solution.solution(_array);

        public class When_the_array_is_empty
        {
            Establish context = () =>
                _array = new int[0];

            It should_return_1 = () =>
                _result.ShouldEqual(1);
        }

        public class When_the_array_contains_at_least_1_element
        {
            Establish context = () =>
                _array = new[] { 1 };

            It should_return_2 = () =>
                _result.ShouldEqual(2);
        }

        public class When_the_missing_number_is_1
        {
            Establish context = () =>
                _array = new[] { 2, 3, 4, 5 };

            It should_return_1 = () =>
                _result.ShouldEqual(1);
        }

        public class When_the_missing_number_is_the_last_one
        {
            Establish context = () =>
                _array = new[] { 1, 2, 3, 4 };

            It should_return_the_last_one = () =>
                _result.ShouldEqual(5);
        }

        public class When_the_missing_number_is_inside
        {
            Establish context = () =>
                _array = new[] { 2, 3, 1, 5 };

            It should_return_that_one = () =>
                _result.ShouldEqual(4);
        }

        public class When_the_number_of_elements_is_the_maximum
        {
            Establish context = () =>
            {
                _array = new int[100000];
                for (int i = 0; i < _array.Length; i++)
                    _array[i] = i + 2;
            };

            It should_return_1 = () =>
                _result.ShouldEqual(1);
        }

        static Solution _solution = new Solution();
        static int _result;
        static int[] _array;
    }
}