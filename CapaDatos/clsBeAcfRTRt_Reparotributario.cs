public class clsBeAcfRTRt_Reparotributario : ICloneable {

	private string mRTRperiodo = '';
	private Date mRTRfecha = Date.Now();
	private string mRTRresponsable = '';
	private bool mRTRestado = False;
	private int mRTRcodigo = 0;

	public String RTRperiodo {
		get {
			return mRTRperiodo;
		}
		set {
			mRTRperiodo = value;
		}
	}

	public Date RTRfecha {
		get {
			return mRTRfecha;
		}
		set {
			mRTRfecha = value;
		}
	}

	public String RTRresponsable {
		get {
			return mRTRresponsable;
		}
		set {
			mRTRresponsable = value;
		}
	}

	public Boolean RTRestado {
		get {
			return mRTRestado;
		}
		set {
			mRTRestado = value;
		}
	}

	public Integer RTRcodigo {
		get {
			return mRTRcodigo;
		}
		set {
			mRTRcodigo = value;
		}
	}

	AcfRTRt_Reparotributario(){
	}

	AcfRTRt_Reparotributario(){ref string RTRperiodo, Date RTRfecha, string RTRresponsable, bool RTRestado, int RTRcodigo)
		mRTRperiodo = RTRperiodo;
		mRTRfecha = RTRfecha;
		mRTRresponsable = RTRresponsable;
		mRTRestado = RTRestado;
		mRTRcodigo = RTRcodigo;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
