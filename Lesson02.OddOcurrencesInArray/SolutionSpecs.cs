using Machine.Specifications;

namespace Lesson02.OddOcurrencesInArray
{
    [Subject(typeof(Solution))]
    public class SolutionSpecs
    {
        Because of = () => 
            _result = _solution.solution(_array);

        public class When_the_size_of_the_array_is_1
        {
            Establish context = () => 
                _array = new []{ 101 };

            It should_return_the_unique_contained_number = () =>
                _result.ShouldEqual(101);
        }

        public class When_the_array_contains_just_one_pair_and_one_odd
        {
            Establish context = () => 
                _array = new []{ 101, 101, 103 };

            It should_return_the_unique_odd_number = () =>
                _result.ShouldEqual(103);
        }

        public class When_the_array_contains_more_than_one_pair
        {
            Establish context = () => 
                _array = new []{ 101, 101, 103, 103, 105 };

            It should_return_the_unique_odd_number = () =>
                _result.ShouldEqual(105);
        }

        public class When_the_array_contains_more_than_one_pair_unordered
        {
            Establish context = () => 
                _array = new []{ 101, 103, 105, 103, 101 };

            It should_return_the_right_odd_number = () =>
                _result.ShouldEqual(105);
        }

        public class When_the_unpaired_odd_number_is_the_first_element
        {
            Establish context = () => 
                _array = new []{ 105, 101, 103, 103, 101 };

            It should_return_the_right_odd_number = () =>
                _result.ShouldEqual(105);
        }

        public class When_its_produced_the_most_extremme_case
        {
            Establish context = () =>
            {
                _array = new int[1000000 - 1];
                for (int i = 0; i < 500000 - 1; i++)
                    _array[i] = 1000000000;
                _array[500000 - 1] = 1;
                for (int i = 500000; i < 1000000 - 1; i++)
                    _array[i] = 1000000000;
            };

            It should_return_the_right_odd_number = () =>
                _result.ShouldEqual(1);
        }

        static Solution _solution = new Solution();
        static int[] _array;
        static int _result;
    }
}