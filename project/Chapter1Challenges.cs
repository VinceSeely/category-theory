namespace project
{
    public class Chapter1Challenges<T>
    {
        public static Func<T, T> Compose(Func<T, T> f, Func<T, T> g)
        {
            return x => f(g(x));
        }

        public static T Identity(T x)
        {
            return x;
        }
    }
}