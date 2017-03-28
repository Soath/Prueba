public class clsBeAcfLOCt_Local : ICloneable {

	private int mLOCid = 0;
	private string mLOClocal = '';
	private string mLOCdireccion = '';
	private string mSEGMENT = '';

	public Integer LOCid {
		get {
			return mLOCid;
		}
		set {
			mLOCid = value;
		}
	}

	public String LOClocal {
		get {
			return mLOClocal;
		}
		set {
			mLOClocal = value;
		}
	}

	public String LOCdireccion {
		get {
			return mLOCdireccion;
		}
		set {
			mLOCdireccion = value;
		}
	}

	public String SEGMENT {
		get {
			return mSEGMENT;
		}
		set {
			mSEGMENT = value;
		}
	}

	AcfLOCt_Local(){
	}

	AcfLOCt_Local(){ref int LOCid, string LOClocal, string LOCdireccion, string SEGMENT)
		mLOCid = LOCid;
		mLOClocal = LOClocal;
		mLOCdireccion = LOCdireccion;
		mSEGMENT = SEGMENT;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
