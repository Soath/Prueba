public class clsBeAcfCMPt_Componente : ICloneable {

	private string mCMPid = '';
	private string mCMPcomponente = '';
	private double mCMPusoestimado = 0.0;
	private double mCMPconservacion = 0.0;
	private double mCMPobsolecencia = 0.0;
	private double mCMPlimitelegal = 0.0;
	private double mCMPtotalfactores = 0.0;
	private double mCMPfactorusoestimado = 0.0;
	private int mCMPvutilanio = 0;
	private int mCMPvutildia = 0;

	public String CMPid {
		get {
			return mCMPid;
		}
		set {
			mCMPid = value;
		}
	}

	public String CMPcomponente {
		get {
			return mCMPcomponente;
		}
		set {
			mCMPcomponente = value;
		}
	}

	public Double CMPusoestimado {
		get {
			return mCMPusoestimado;
		}
		set {
			mCMPusoestimado = value;
		}
	}

	public Double CMPconservacion {
		get {
			return mCMPconservacion;
		}
		set {
			mCMPconservacion = value;
		}
	}

	public Double CMPobsolecencia {
		get {
			return mCMPobsolecencia;
		}
		set {
			mCMPobsolecencia = value;
		}
	}

	public Double CMPlimitelegal {
		get {
			return mCMPlimitelegal;
		}
		set {
			mCMPlimitelegal = value;
		}
	}

	public Double CMPtotalfactores {
		get {
			return mCMPtotalfactores;
		}
		set {
			mCMPtotalfactores = value;
		}
	}

	public Double CMPfactorusoestimado {
		get {
			return mCMPfactorusoestimado;
		}
		set {
			mCMPfactorusoestimado = value;
		}
	}

	public Integer CMPvutilanio {
		get {
			return mCMPvutilanio;
		}
		set {
			mCMPvutilanio = value;
		}
	}

	public Integer CMPvutildia {
		get {
			return mCMPvutildia;
		}
		set {
			mCMPvutildia = value;
		}
	}

	AcfCMPt_Componente(){
	}

	AcfCMPt_Componente(){ref string CMPid, string CMPcomponente, double CMPusoestimado, double CMPconservacion, double CMPobsolecencia, double CMPlimitelegal, double CMPtotalfactores, double CMPfactorusoestimado, int CMPvutilanio, int CMPvutildia)
		mCMPid = CMPid;
		mCMPcomponente = CMPcomponente;
		mCMPusoestimado = CMPusoestimado;
		mCMPconservacion = CMPconservacion;
		mCMPobsolecencia = CMPobsolecencia;
		mCMPlimitelegal = CMPlimitelegal;
		mCMPtotalfactores = CMPtotalfactores;
		mCMPfactorusoestimado = CMPfactorusoestimado;
		mCMPvutilanio = CMPvutilanio;
		mCMPvutildia = CMPvutildia;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
