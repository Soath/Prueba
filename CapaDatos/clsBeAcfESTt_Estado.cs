public class clsBeAcfESTt_Estado : ICloneable {

	private int mESTid = 0;
	private string mESTestado = '';

	public Integer ESTid {
		get {
			return mESTid;
		}
		set {
			mESTid = value;
		}
	}

	public String ESTestado {
		get {
			return mESTestado;
		}
		set {
			mESTestado = value;
		}
	}

	AcfESTt_Estado(){
	}

	AcfESTt_Estado(){ref int ESTid, string ESTestado)
		mESTid = ESTid;
		mESTestado = ESTestado;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
