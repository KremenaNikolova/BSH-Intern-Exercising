namespace Lab5.Optional.Helpers
{
    public class CustomPriorityAttribute : Attribute
    {
        public CustomPriorityAttribute(int priority, bool isDescending = false)
        {
            Priority = priority;
            IsDescending = isDescending;

        }

        public int Priority { get; }

        public bool IsDescending { get; }

    }
}
