public class clsBeAcfCSTt_Costo : ICloneable {

	private string mCSTid = '';
	private string mCSTdescripcion = '';
	private string mCSTdetalle = '';
	private string mCSTabreviado = '';
	private string mACTid = '';
	private string mCSTid_costo = '';

	public String CSTid {
		get {
			return mCSTid;
		}
		set {
			mCSTid = value;
		}
	}

	public String CSTdescripcion {
		get {
			return mCSTdescripcion;
		}
		set {
			mCSTdescripcion = value;
		}
	}

	public String CSTdetalle {
		get {
			return mCSTdetalle;
		}
		set {
			mCSTdetalle = value;
		}
	}

	public String CSTabreviado {
		get {
			return mCSTabreviado;
		}
		set {
			mCSTabreviado = value;
		}
	}

	public String ACTid {
		get {
			return mACTid;
		}
		set {
			mACTid = value;
		}
	}

	public String CSTid_costo {
		get {
			return mCSTid_costo;
		}
		set {
			mCSTid_costo = value;
		}
	}

	AcfCSTt_Costo(){
	}

	AcfCSTt_Costo(){ref string CSTid, string CSTdescripcion, string CSTdetalle, string CSTabreviado, string ACTid, string CSTid_costo)
		mCSTid = CSTid;
		mCSTdescripcion = CSTdescripcion;
		mCSTdetalle = CSTdetalle;
		mCSTabreviado = CSTabreviado;
		mACTid = ACTid;
		mCSTid_costo = CSTid_costo;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
