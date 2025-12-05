using System;

namespace CS586Project
{
    public enum TVType
    {
        Basic,
        Smart
    }

    public static class TVFactory
    {
        public static iTV CreateTV(TVType type)
        {
            switch (type)
            {
                case TVType.Basic:
                    return new TV();
                case TVType.Smart:
                    var smart = new SmartTV();

                    smart.PowerToggle();
                    smart.SmartModeToggle();

                    return smart;
                default:
                    throw new ArgumentException("Invalid TV type");
            }
        }
    }
}