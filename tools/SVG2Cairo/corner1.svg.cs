public void Drawcorner1_svg(Context cr, int x, int y, float width, float height, double[] rgba) {
	ImageSurface temp_surface;
	Context old_cr;
	Pattern pattern = null;
	Matrix matrix = cr.Matrix;
	
	cr.Save();
	float w = 1024;
	float h = 1024;
	float scale = Math.Min(width / w, height / h);
	matrix.Translate(x + Math.Max(0, (width - w * scale) / 2), y + Math.Max(0, (height - h * scale) / 2));
	matrix.Scale(scale, scale);
	cr.Matrix = matrix;

	cr.Operator = Operator.Over;
	pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
	cr.SetSource(pattern);
	
	cr.NewPath();
	cr.MoveTo(304.226563, 272.78125);
	cr.LineTo(527.988281, 685.785156);
	cr.LineTo(919.699219, 463.308594);
	cr.LineTo(735.460938, 140.246094);
	cr.ClosePath();
	cr.MoveTo(304.226563, 272.78125);
	cr.Tolerance = 0.1;
	cr.Antialias = Antialias.Default;
	cr.FillRule = FillRule.Winding;
	cr.FillPreserve();
	if (pattern!= null) pattern.Dispose();

	cr.Operator = Operator.Over;
	cr.LineWidth = 0.264583;
	cr.MiterLimit = 4;
	cr.LineCap = LineCap.Butt;
	cr.LineJoin = LineJoin.Miter;
	pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
	cr.SetSource(pattern);
	
	cr.NewPath();
	cr.MoveTo(304.226563, 272.78125);
	cr.LineTo(527.988281, 685.785156);
	cr.LineTo(919.699219, 463.308594);
	cr.LineTo(735.460938, 140.246094);
	cr.ClosePath();
	cr.MoveTo(304.226563, 272.78125);
	cr.Tolerance = 0.1;
	cr.Antialias = Antialias.Default;
matrix = new Matrix(3.779527,0,0,3.779527,0.0000188976,0);
pattern.Matrix = matrix;
	cr.StrokePreserve();
	if (pattern!= null) pattern.Dispose();

	cr.Operator = Operator.Over;
	pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
	cr.SetSource(pattern);
	
	cr.NewPath();
	cr.MoveTo(300.226563, 260.78125);
	cr.LineTo(131.785156, 179.71875);
	cr.LineTo(549.960938, 76.734375);
	cr.LineTo(731.460938, 128.246094);
	cr.Tolerance = 0.1;
	cr.Antialias = Antialias.Default;
	cr.FillRule = FillRule.Winding;
	cr.FillPreserve();
	if (pattern!= null) pattern.Dispose();

	cr.Operator = Operator.Over;
	cr.LineWidth = 0.264583;
	cr.MiterLimit = 4;
	cr.LineCap = LineCap.Butt;
	cr.LineJoin = LineJoin.Miter;
	pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
	cr.SetSource(pattern);
	
	cr.NewPath();
	cr.MoveTo(300.226563, 260.78125);
	cr.LineTo(131.785156, 179.71875);
	cr.LineTo(549.960938, 76.734375);
	cr.LineTo(731.460938, 128.246094);
	cr.Tolerance = 0.1;
	cr.Antialias = Antialias.Default;
matrix = new Matrix(3.779527,0,0,3.779527,0.0000188976,0);
pattern.Matrix = matrix;
	cr.StrokePreserve();
	if (pattern!= null) pattern.Dispose();

	cr.Operator = Operator.Over;
	pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
	cr.SetSource(pattern);
	
	cr.NewPath();
	cr.MoveTo(529.796875, 690.511719);
	cr.LineTo(528.5, 931.648438);
	cr.LineTo(886.988281, 679.261719);
	cr.LineTo(921.699219, 467.308594);
	cr.Tolerance = 0.1;
	cr.Antialias = Antialias.Default;
	cr.FillRule = FillRule.Winding;
	cr.FillPreserve();
	if (pattern!= null) pattern.Dispose();

	cr.Operator = Operator.Over;
	cr.LineWidth = 0.264583;
	cr.MiterLimit = 4;
	cr.LineCap = LineCap.Butt;
	cr.LineJoin = LineJoin.Miter;
	pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
	cr.SetSource(pattern);
	
	cr.NewPath();
	cr.MoveTo(529.796875, 690.511719);
	cr.LineTo(528.5, 931.648438);
	cr.LineTo(886.988281, 679.261719);
	cr.LineTo(921.699219, 467.308594);
	cr.Tolerance = 0.1;
	cr.Antialias = Antialias.Default;
matrix = new Matrix(3.779527,0,0,3.779527,0.0000188976,0);
pattern.Matrix = matrix;
	cr.StrokePreserve();
	if (pattern!= null) pattern.Dispose();

	cr.Operator = Operator.Over;
	pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
	cr.SetSource(pattern);
	
	cr.NewPath();
	cr.MoveTo(519.984375, 689.785156);
	cr.LineTo(296.058594, 276.613281);
	cr.LineTo(127.90625, 195.628906);
	cr.LineTo(194.152344, 660.5);
	cr.LineTo(518.273438, 931.691406);
	cr.LineTo(519.984375, 689.785156);
	cr.Tolerance = 0.1;
	cr.Antialias = Antialias.Default;
	cr.FillRule = FillRule.Winding;
	cr.FillPreserve();
	if (pattern!= null) pattern.Dispose();

	cr.Operator = Operator.Over;
	cr.LineWidth = 0.264583;
	cr.MiterLimit = 4;
	cr.LineCap = LineCap.Butt;
	cr.LineJoin = LineJoin.Miter;
	pattern = new SolidPattern(rgba[0], rgba[1], rgba[2], rgba[3]);
	cr.SetSource(pattern);
	
	cr.NewPath();
	cr.MoveTo(519.984375, 689.785156);
	cr.LineTo(296.058594, 276.613281);
	cr.LineTo(127.90625, 195.628906);
	cr.LineTo(194.152344, 660.5);
	cr.LineTo(518.273438, 931.691406);
	cr.LineTo(519.984375, 689.785156);
	cr.Tolerance = 0.1;
	cr.Antialias = Antialias.Default;
matrix = new Matrix(3.779527,0,0,3.779527,0.0000188976,0);
pattern.Matrix = matrix;
	cr.StrokePreserve();
	if (pattern!= null) pattern.Dispose();

	cr.Restore();
}

