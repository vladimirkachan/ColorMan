namespace ColorMan.ColorSpaces.Converter
{
    public static class Extension
    {
	    //      A  B  C     00 10 20
        //      D  E  F     01 11 21
        //      G  H  I     02 12 22
        public static Matric Inverse(this Matric matric)
        {
            double v0 = matric.EItem * matric.IItem - matric.HItem * matric.FItem;
            double v1 = matric.GItem * matric.FItem - matric.DItem * matric.IItem;
            double v2 = matric.DItem * matric.HItem - matric.GItem * matric.EItem;
            double v3 = matric.HItem * matric.CItem - matric.BItem * matric.IItem;
            double v4 = matric.AItem * matric.IItem - matric.GItem * matric.CItem;
            double v5 = matric.GItem * matric.BItem - matric.AItem * matric.HItem;
            double v6 = matric.BItem * matric.FItem - matric.EItem * matric.CItem;
            double v7 = matric.DItem * matric.CItem - matric.AItem * matric.FItem;
            double v8 = matric.AItem * matric.EItem - matric.DItem * matric.BItem;
            double det = matric.AItem * v0 + matric.DItem * v3 + matric.GItem * v6;
            return new Matric(v0 / det, v3 / det, v6 / det, v1 / det, v4 / det, v7 / det, v2 / det, v5 / det, v8 / det);
        }
    }
}
