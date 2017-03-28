public class clsBeBdiCDDpClasesDeDocumento : ICloneable {

	private string mBLART = '';
	private string mLTEXT = '';
	private string mDETdoctipo = '';

	public String BLART {
		get {
			return mBLART;
		}
		set {
			mBLART = value;
		}
	}

	public String LTEXT {
		get {
			return mLTEXT;
		}
		set {
			mLTEXT = value;
		}
	}

	public String DETdoctipo {
		get {
			return mDETdoctipo;
		}
		set {
			mDETdoctipo = value;
		}
	}

	BdiCDDpClasesDeDocumento(){
	}

	BdiCDDpClasesDeDocumento(){ref string BLART, string LTEXT, string DETdoctipo)
		mBLART = BLART;
		mLTEXT = LTEXT;
		mDETdoctipo = DETdoctipo;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
