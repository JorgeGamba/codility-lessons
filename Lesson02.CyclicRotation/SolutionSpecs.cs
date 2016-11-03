using Machine.Specifications;

namespace Lesson02.CyclicRotation
{
    [Subject(typeof(Solution))]
    public class SolutionSpecs
    {
        Because of = () => 
            _result = _solution.solution(_array, _rotation);

        public class When_the_array_is_empty
        {
            private Establish context = () =>
            {
                _array = new int[0];
                _rotation = _anyRotation;
            };

            It should_return_the_original_array = () =>
                _result.ShouldEqual(_array);
        }

        public class When_the_array_contains_just_one_element
        {
            Establish context = () =>
            {
                _array = new[] {100};
                _rotation = _anyRotation;
            };

            It should_return_the_original_array = () =>
                _result.ShouldEqual(_array);
        }

        public class When_the_rotation_is_0
        {
            Establish context = () =>
            {
                _array = new[] {100, 101};
                _rotation = 0;
            };

            It should_return_the_original_array = () =>
                _result.ShouldEqual(_array);
        }

        public class When_the_rotation_is_1
        {
            Establish context = () =>
            {
                _array = new[] {100, 101};
                _rotation = 1;
            };

            It should_return_the_array_roted = () =>
                _result.ShouldEqual(new [] { 101, 100 });
        }

        public class When_the_rotation_is_greather_than_1
        {
            Establish context = () =>
            {
                _array = new[] { 1, 2, 3, 4, 5, 6, 7 };
                _rotation = 3;
            };

            It should_return_the_array_roted = () =>
                _result.ShouldEqual(new [] { 5, 6, 7, 1, 2, 3, 4 });
        }

        public class When_the_rotation_is_equal_to_the_size_of_the_array
        {
            Establish context = () =>
            {
                _array = new[] { 1, 2, 3, 4, 5, 6, 7 };
                _rotation = _array.Length;
            };

            It should_return_the_original_array = () =>
                _result.ShouldEqual(_array);
        }

        public class When_the_rotation_is_greather_than_the_size_of_the_array
        {
            Establish context = () =>
            {
                _array = new[] { 1, 2, 3, 4, 5, 6, 7 };
                _rotation = _array.Length + 2;
            };

            It should_return_the_array_roted = () =>
                _result.ShouldEqual(new[] { 6, 7, 1, 2, 3, 4, 5 });
        }

        public class When_the_rotation_is_many_times_greather_than_the_size_of_the_array
        {
            Establish context = () =>
            {
                _array = new[] { 1, 2, 3, 4, 5, 6, 7 };
                _rotation = _array.Length * 3 + 2;
            };

            It should_return_the_array_roted = () =>
                _result.ShouldEqual(new[] { 6, 7, 1, 2, 3, 4, 5 });
        }

        public class When_both_the_rotation_and_the_array_size_have_their_maximum_values
        {
            Establish context = () =>
            {
                _array = new int[100];
                for (int i = 0; i < 50; i++)
                    _array[i] = -1000;
                for (int i = 50; i < 100; i++)
                    _array[i] = 1000;
                _rotation = 100;
            };

            It should_return_the_original_array = () =>
                _result.ShouldEqual(_array);
        }

        static Solution _solution = new Solution();
        static int[] _array;
        static int _rotation;
        static int[] _result;
        static int _anyRotation = 1;
    }
}