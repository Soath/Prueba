public class clsBeBdiSEGpSegmento : ICloneable {

	private string mSEGMENT = '';
	private string mNAME = '';
	private string mId_zona = '';

	public String SEGMENT {
		get {
			return mSEGMENT;
		}
		set {
			mSEGMENT = value;
		}
	}

	public String NAME {
		get {
			return mNAME;
		}
		set {
			mNAME = value;
		}
	}

	public String Id_zona {
		get {
			return mId_zona;
		}
		set {
			mId_zona = value;
		}
	}

	BdiSEGpSegmento(){
	}

	BdiSEGpSegmento(){ref string SEGMENT, string NAME, string id_zona)
		mSEGMENT = SEGMENT;
		mNAME = NAME;
		mId_zona = Id_zona;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
