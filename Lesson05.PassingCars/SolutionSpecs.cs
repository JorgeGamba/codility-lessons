using Machine.Specifications;

namespace Lesson05.PassingCars
{
    [Subject(typeof(Solution))]
    public class SolutionSpecs
    {
        Because of = () =>
            _result = _solution.solution(A);

        public class on_provided_example
        {
            Establish context = () =>
                A = new [] {0, 1, 0, 1, 1};

            It should_return_the_expected_result = () =>
                _result.ShouldEqual(5);
        }

        public class When_all_cars_travel_to_east
        {
            Establish context = () =>
                A = new [] {0, 0, 0, 0, 0};

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        public class When_all_cars_travel_to_west
        {
            Establish context = () =>
                A = new [] {1, 1, 1, 1, 1};

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        public class When_only_the_first_car_travel_to_east
        {
            Establish context = () =>
                A = new [] {0, 1, 1, 1, 1};

            It should_return_the_quantity_minus_1 = () =>
                _result.ShouldEqual(4);
        }

        public class When_only_the_last_car_travel_to_west
        {
            Establish context = () =>
                A = new [] {0, 0, 0, 0, 1};

            It should_return_the_quantity_minus_1 = () =>
                _result.ShouldEqual(4);
        }

        public class When_only_the_first_car_travel_to_west
        {
            Establish context = () =>
                A = new [] {1, 0, 0, 0, 0};

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        public class When_only_the_last_car_travel_to_east
        {
            Establish context = () =>
                A = new [] {1, 1, 1, 1, 0};

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        public class When_there_is_just_1_car_traveling_to_east
        {
            Establish context = () =>
                A = new[] { 0 };

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        public class When_there_is_just_1_car_traveling_to_west
        {
            Establish context = () =>
                A = new[] { 1 };

            It should_return_0 = () =>
                _result.ShouldEqual(0);
        }

        public class When_it_passes_the_1000000000_passing_cars
        {
            Establish context = () =>
            {
                A = new int[100000];
                for (int i = 0; i < 50000; i++)
                    A[i] = 0;
                for (int i = 50000; i < 100000; i++)
                    A[i] = 1;
            };

            It should_return_minus_1 = () =>
                _result.ShouldEqual(-1);
        }

        static Solution _solution = new Solution();
        static int[] A;
        static int _result;
    }
}