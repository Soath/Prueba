public class clsBeAcfMARt_Marca : ICloneable {

	private int mMARid = 0;
	private string mMARmarca = '';

	public Integer MARid {
		get {
			return mMARid;
		}
		set {
			mMARid = value;
		}
	}

	public String MARmarca {
		get {
			return mMARmarca;
		}
		set {
			mMARmarca = value;
		}
	}

	AcfMARt_Marca(){
	}

	AcfMARt_Marca(){ref int MARid, string MARmarca)
		mMARid = MARid;
		mMARmarca = MARmarca;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
