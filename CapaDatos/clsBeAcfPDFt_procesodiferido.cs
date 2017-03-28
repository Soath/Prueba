public class clsBeAcfPDFt_procesodiferido : ICloneable {

	private int mPDFcodigo = 0;
	private string mPDFperiodo = '';
	private Date mPDFfecha = Date.Now();
	private string mPDFreponsable = '';
	private bool mPDFestado = False;

	public Integer PDFcodigo {
		get {
			return mPDFcodigo;
		}
		set {
			mPDFcodigo = value;
		}
	}

	public String PDFperiodo {
		get {
			return mPDFperiodo;
		}
		set {
			mPDFperiodo = value;
		}
	}

	public Date PDFfecha {
		get {
			return mPDFfecha;
		}
		set {
			mPDFfecha = value;
		}
	}

	public String PDFreponsable {
		get {
			return mPDFreponsable;
		}
		set {
			mPDFreponsable = value;
		}
	}

	public Boolean PDFestado {
		get {
			return mPDFestado;
		}
		set {
			mPDFestado = value;
		}
	}

	AcfPDFt_procesodiferido(){
	}

	AcfPDFt_procesodiferido(){ref int PDFcodigo, string PDFperiodo, Date PDFfecha, string PDFreponsable, bool PDFestado)
		mPDFcodigo = PDFcodigo;
		mPDFperiodo = PDFperiodo;
		mPDFfecha = PDFfecha;
		mPDFreponsable = PDFreponsable;
		mPDFestado = PDFestado;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
