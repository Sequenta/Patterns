using Strategy.Startegies;

namespace Strategy
{
    public class ShirtFactory
    {
        public IMakingStrategy MakingStrategy { get; set; }
 
        public void MakeShirts()
        {
            MakingStrategy.Perform();
        }
    }
}