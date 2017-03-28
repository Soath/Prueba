public class clsBeAcfDRTt_detallereparotributario : ICloneable {

	private int mRTRcodigo = 0;
	private string mACFcuenta = '';
	private string mINVZU = '';
	private string mTXT50 = '';
	private double mACFfactorniif = 0.0;
	private double mACFvutilniif = 0.0;
	private double mACFfactorTrib = 0.0;
	private double mACFvutiltrib = 0.0;
	private double mACFvalorniif = 0.0;
	private double mACFdepAcuniif = 0.0;
	private double mACFNiifNeto = 0.0;
	private double mACFDepNiifPer = 0.0;
	private double mACFvalortrib = 0.0;
	private double mACFdepacutrib = 0.0;
	private double mACFlirneto = 0.0;
	private double mACFdeptlirper = 0.0;
	private double mACFadiciones = 0.0;
	private double mACFdeducciones = 0.0;
	private double mACFneto = 0.0;

	public Integer RTRcodigo {
		get {
			return mRTRcodigo;
		}
		set {
			mRTRcodigo = value;
		}
	}

	public String ACFcuenta {
		get {
			return mACFcuenta;
		}
		set {
			mACFcuenta = value;
		}
	}

	public String INVZU {
		get {
			return mINVZU;
		}
		set {
			mINVZU = value;
		}
	}

	public String TXT50 {
		get {
			return mTXT50;
		}
		set {
			mTXT50 = value;
		}
	}

	public Double ACFfactorniif {
		get {
			return mACFfactorniif;
		}
		set {
			mACFfactorniif = value;
		}
	}

	public Double ACFvutilniif {
		get {
			return mACFvutilniif;
		}
		set {
			mACFvutilniif = value;
		}
	}

	public Double ACFfactorTrib {
		get {
			return mACFfactorTrib;
		}
		set {
			mACFfactorTrib = value;
		}
	}

	public Double ACFvutiltrib {
		get {
			return mACFvutiltrib;
		}
		set {
			mACFvutiltrib = value;
		}
	}

	public Double ACFvalorniif {
		get {
			return mACFvalorniif;
		}
		set {
			mACFvalorniif = value;
		}
	}

	public Double ACFdepAcuniif {
		get {
			return mACFdepAcuniif;
		}
		set {
			mACFdepAcuniif = value;
		}
	}

	public Double ACFNiifNeto {
		get {
			return mACFNiifNeto;
		}
		set {
			mACFNiifNeto = value;
		}
	}

	public Double ACFDepNiifPer {
		get {
			return mACFDepNiifPer;
		}
		set {
			mACFDepNiifPer = value;
		}
	}

	public Double ACFvalortrib {
		get {
			return mACFvalortrib;
		}
		set {
			mACFvalortrib = value;
		}
	}

	public Double ACFdepacutrib {
		get {
			return mACFdepacutrib;
		}
		set {
			mACFdepacutrib = value;
		}
	}

	public Double ACFlirneto {
		get {
			return mACFlirneto;
		}
		set {
			mACFlirneto = value;
		}
	}

	public Double ACFdeptlirper {
		get {
			return mACFdeptlirper;
		}
		set {
			mACFdeptlirper = value;
		}
	}

	public Double ACFadiciones {
		get {
			return mACFadiciones;
		}
		set {
			mACFadiciones = value;
		}
	}

	public Double ACFdeducciones {
		get {
			return mACFdeducciones;
		}
		set {
			mACFdeducciones = value;
		}
	}

	public Double ACFneto {
		get {
			return mACFneto;
		}
		set {
			mACFneto = value;
		}
	}

	AcfDRTt_detallereparotributario(){
	}

	AcfDRTt_detallereparotributario(){ref int RTRcodigo, string ACFcuenta, string INVZU, string TXT50, double ACFfactorniif, double ACFvutilniif, double ACFfactorTrib, double ACFvutiltrib, double ACFvalorniif, double ACFdepAcuniif, double ACFNiifNeto, double ACFDepNiifPer, double ACFvalortrib, double ACFdepacutrib, double ACFlirneto, double ACFdeptlirper, double ACFadiciones, double ACFdeducciones, double ACFneto)
		mRTRcodigo = RTRcodigo;
		mACFcuenta = ACFcuenta;
		mINVZU = INVZU;
		mTXT50 = TXT50;
		mACFfactorniif = ACFfactorniif;
		mACFvutilniif = ACFvutilniif;
		mACFfactorTrib = ACFfactorTrib;
		mACFvutiltrib = ACFvutiltrib;
		mACFvalorniif = ACFvalorniif;
		mACFdepAcuniif = ACFdepAcuniif;
		mACFNiifNeto = ACFNiifNeto;
		mACFDepNiifPer = ACFDepNiifPer;
		mACFvalortrib = ACFvalortrib;
		mACFdepacutrib = ACFdepacutrib;
		mACFlirneto = ACFlirneto;
		mACFdeptlirper = ACFdeptlirper;
		mACFadiciones = ACFadiciones;
		mACFdeducciones = ACFdeducciones;
		mACFneto = ACFneto;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
