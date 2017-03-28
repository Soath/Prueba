public class clsBeAcfMATt_Material : ICloneable {

	private int mMATid = 0;
	private string mMATmaterial = '';
	private string mMATabreviado = '';

	public Integer MATid {
		get {
			return mMATid;
		}
		set {
			mMATid = value;
		}
	}

	public String MATmaterial {
		get {
			return mMATmaterial;
		}
		set {
			mMATmaterial = value;
		}
	}

	public String MATabreviado {
		get {
			return mMATabreviado;
		}
		set {
			mMATabreviado = value;
		}
	}

	AcfMATt_Material(){
	}

	AcfMATt_Material(){ref int MATid, string MATmaterial, string MATabreviado)
		mMATid = MATid;
		mMATmaterial = MATmaterial;
		mMATabreviado = MATabreviado;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
