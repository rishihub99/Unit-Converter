namespace UnitConverter.WebAPI
{
    public static class Units
    {
        public static double[] lenVal()
        {
            return new double[] { 0.3048, 0.0254, 1.0000, 1000 };
        } //{ get { return new double[] { 0.3048, 0.0254, 1.0000, 1000 }; } }//= ;
        public static double[] massVal { get { return new double[] { 0.453592, 0.0283495, 0.001, 1.0000 }; } }// = { 0.453592, 0.0283495, 0.001, 1.0000 };
        public static double[] timeVal { get { return new double[] { 1, 0.001 }; } }// = ;
    }

}

