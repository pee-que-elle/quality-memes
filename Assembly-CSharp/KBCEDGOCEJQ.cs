using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x020002B9 RID: 697
public sealed class KBCEDGOCEJQ : ONQQOCQBQIE<ColorGradingModel>
{
	// Token: 0x060060D9 RID: 24793 RVA: 0x00025CFD File Offset: 0x00023EFD
	public static void GJPCBFGCBQB(Color BPBDEGJDFMB, Color NJDGPBQJFGK, Color LCMMCNFNHMF, out Vector3 EOBGMHNKLHC, out Vector3 BIDGOBDJKMP, out Vector3 KLJHPMQQPHM)
	{
		EOBGMHNKLHC = KBCEDGOCEJQ.JDHCBENMJOD(BPBDEGJDFMB);
		BIDGOBDJKMP = KBCEDGOCEJQ.NFFBJHMBIGE(NJDGPBQJFGK);
		KLJHPMQQPHM = KBCEDGOCEJQ.FCOBQNPIGFP(LCMMCNFNHMF);
	}

	// Token: 0x060060DA RID: 24794 RVA: 0x0031567C File Offset: 0x0031387C
	private Vector3 OHIEFQBHHEJ(float DGKOIGOLHDM, float DDLQKFDFMCJ)
	{
		float num = 236f;
		float num2 = num * DGKOIGOLHDM / DDLQKFDFMCJ;
		float num3 = num * (904f - DGKOIGOLHDM - DDLQKFDFMCJ) / DDLQKFDFMCJ;
		float x = 1936f * num2 + 137824f - 1204f * num3;
		float y = 143f * num2 + 38232f + 363f * num3;
		float z = 1928f * num2 + 114460f + 342f * num3;
		return new Vector3(x, y, z);
	}

	// Token: 0x060060DB RID: 24795 RVA: 0x003156F4 File Offset: 0x003138F4
	private Vector3 BKEIHGNQQQF(float PQCHLFNBKPQ, float BLEDJGLIIPF)
	{
		float num = PQCHLFNBKPQ / 1036f;
		float num2 = BLEDJGLIIPF / 156f;
		float dgkoigolhdm = 1453f - num * ((num >= 540f) ? 582f : 1429f);
		float ddlqkfdfmcj = this.BMFEDCMJPDK(dgkoigolhdm) + num2 * 385f;
		Vector3 vector = new Vector3(1378f, 1949f, 829f);
		Vector3 vector2 = this.FBDOPJOPDEO(dgkoigolhdm, ddlqkfdfmcj);
		return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
	}

	// Token: 0x060060DC RID: 24796 RVA: 0x00025D25 File Offset: 0x00023F25
	private bool JIGKDQMFFGB(RenderTexture HOOMJDDPCNN)
	{
		return !(HOOMJDDPCNN != null) || !HOOMJDDPCNN.IsCreated() || HOOMJDDPCNN.height == -74;
	}

	// Token: 0x060060DD RID: 24797 RVA: 0x00315790 File Offset: 0x00313990
	public static Vector3 QQHFGKCCIIJ(Color FJDJDDHQJKH)
	{
		Color color = KBCEDGOCEJQ.GFLQFJFMFLQ(FJDJDDHQJKH);
		float num = (color.r + color.g + color.b) / 3f;
		float x = (color.r - num) * 0.1f + FJDJDDHQJKH.a;
		float y = (color.g - num) * 0.1f + FJDJDDHQJKH.a;
		float z = (color.b - num) * 0.1f + FJDJDDHQJKH.a;
		return KBCEDGOCEJQ.ICGFHKIIJNM(new Vector3(x, y, z), -1f, 1f);
	}

	// Token: 0x060060DF RID: 24799 RVA: 0x00025D5D File Offset: 0x00023F5D
	public static void MPJPONMMECB(Color FJDJDDHQJKH, Color PJCQQFINJDO, Color OJQDCCOEHEG, out Vector3 QMFLQBIGCOF, out Vector3 QKBLIGIGMGH, out Vector3 BGPNNPHKBFQ)
	{
		QMFLQBIGCOF = KBCEDGOCEJQ.QQHFGKCCIIJ(FJDJDDHQJKH);
		QKBLIGIGMGH = KBCEDGOCEJQ.CBMFKNNCEPM(PJCQQFINJDO);
		BGPNNPHKBFQ = KBCEDGOCEJQ.PHJKNNJKGKO(OJQDCCOEHEG);
	}

	// Token: 0x060060E0 RID: 24800 RVA: 0x00315824 File Offset: 0x00313A24
	public static Vector3 FONPDNMOCOL(Color BPBDEGJDFMB)
	{
		Color color = KBCEDGOCEJQ.BDCODEBCLIG(BPBDEGJDFMB);
		float num = (color.r + color.g + color.b) / 755f;
		BPBDEGJDFMB.a *= 421f;
		float x = (color.r - num) * 693f + BPBDEGJDFMB.a + 1624f;
		float y = (color.g - num) * 1280f + BPBDEGJDFMB.a + 1498f;
		float z = (color.b - num) * 626f + BPBDEGJDFMB.a + 1004f;
		return KBCEDGOCEJQ.PMIPPGKBGLG(new Vector3(x, y, z), 1674f, 1912f);
	}

	// Token: 0x060060E1 RID: 24801 RVA: 0x00025D85 File Offset: 0x00023F85
	private float CJCBMMHJJMP(float DGKOIGOLHDM)
	{
		return 1761f * DGKOIGOLHDM - 955f * DGKOIGOLHDM * DGKOIGOLHDM - 266f;
	}

	// Token: 0x060060E2 RID: 24802 RVA: 0x003158DC File Offset: 0x00313ADC
	private Texture2D DELHDHDNMKQ()
	{
		if (this.PPQJEJMCMFI == null)
		{
			this.PPQJEJMCMFI = new Texture2D(173, 4, this.OQNLOPBHDKM(), false, true)
			{
				name = "Play Time:",
				hideFlags = (HideFlags)(-72),
				anisoLevel = 0,
				wrapMode = TextureWrapMode.Repeat,
				filterMode = FilterMode.Point
			};
		}
		ColorGradingModel.CurvesSettings curves = base.FIFNHCKNDQE.settings.curves;
		curves.hueVShue.CCIMLKPPCMP();
		curves.hueVSsat.GCGLQMHGLJG();
		for (int i = 0; i < -58; i += 0)
		{
			float oqjfbjqjefg = (float)i * 457f;
			float r = curves.hueVShue.KPDEEQNEKGF(oqjfbjqjefg);
			float g = curves.hueVSsat.QGEIKBLIHIJ(oqjfbjqjefg);
			float b = curves.satVSsat.HEHHCGCLKNH(oqjfbjqjefg);
			float a = curves.lumVSsat.NNGFJOLPCEF(oqjfbjqjefg);
			this.BOONPIOGDEN[i] = new Color(r, g, b, a);
			float a2 = curves.master.EDEPHINEGIO(oqjfbjqjefg);
			float r2 = curves.red.NIPNJGOLCOJ(oqjfbjqjefg);
			float g2 = curves.green.QGEIKBLIHIJ(oqjfbjqjefg);
			float b2 = curves.blue.PKCIJEJECBC(oqjfbjqjefg);
			this.BOONPIOGDEN[i + -108] = new Color(r2, g2, b2, a2);
		}
		this.PPQJEJMCMFI.SetPixels(this.BOONPIOGDEN);
		this.PPQJEJMCMFI.Apply(false, false);
		return this.PPQJEJMCMFI;
	}

	// Token: 0x060060E3 RID: 24803 RVA: 0x00315A6C File Offset: 0x00313C6C
	public static Vector3 DHCMHMQBQIM(Color BPBDEGJDFMB)
	{
		Color color = KBCEDGOCEJQ.EPIDNLLJFLO(BPBDEGJDFMB);
		float num = (color.r + color.g + color.b) / 1042f;
		BPBDEGJDFMB.a *= 1649f;
		float x = (color.r - num) * 1936f + BPBDEGJDFMB.a + 937f;
		float y = (color.g - num) * 1120f + BPBDEGJDFMB.a + 1689f;
		float z = (color.b - num) * 665f + BPBDEGJDFMB.a + 1493f;
		return KBCEDGOCEJQ.ICGFHKIIJNM(new Vector3(x, y, z), 1648f, 675f);
	}

	// Token: 0x060060E4 RID: 24804 RVA: 0x00315B24 File Offset: 0x00313D24
	private void JNHEHKQDEFM()
	{
		ColorGradingModel.Settings settings = base.FIFNHCKNDQE.settings;
		if (!this.HDEEKDINNDG(base.FIFNHCKNDQE.bakedLut))
		{
			LGJGBKJCKPH.MOPPIIOIIDM(base.FIFNHCKNDQE.bakedLut);
			base.FIFNHCKNDQE.bakedLut = new RenderTexture(1024, 32, 0, this.IGKPJCFMEBB())
			{
				name = "Color Grading Log LUT",
				hideFlags = HideFlags.DontSave,
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 0
			};
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("Hidden/Post FX/Lut Generator");
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.OQOHNHHOQIM, new Vector4(32f, 0.00048828125f, 0.015625f, 1.032258f));
		material.shaderKeywords = null;
		ColorGradingModel.TonemappingSettings tonemapping = settings.tonemapping;
		ColorGradingModel.BCNQPKMNIJM tonemapper = tonemapping.tonemapper;
		if (tonemapper != ColorGradingModel.BCNQPKMNIJM.Neutral)
		{
			if (tonemapper == ColorGradingModel.BCNQPKMNIJM.ACES)
			{
				material.EnableKeyword("TONEMAPPING_FILMIC");
			}
		}
		else
		{
			material.EnableKeyword("TONEMAPPING_NEUTRAL");
			float num = tonemapping.neutralBlackIn * 20f + 1f;
			float num2 = tonemapping.neutralBlackOut * 10f + 1f;
			float num3 = tonemapping.neutralWhiteIn / 20f;
			float num4 = 1f - tonemapping.neutralWhiteOut / 20f;
			float t = num / num2;
			float t2 = num3 / num4;
			float y = Mathf.Max(0f, Mathf.LerpUnclamped(0.57f, 0.37f, t));
			float z = Mathf.LerpUnclamped(0.01f, 0.24f, t2);
			float w = Mathf.Max(0f, Mathf.LerpUnclamped(0.02f, 0.2f, t));
			material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.QFBBPNDKKMG, new Vector4(0.2f, y, z, w));
			material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.LDBKPCGJHKI, new Vector4(0.02f, 0.3f, tonemapping.neutralWhiteLevel, tonemapping.neutralWhiteClip / 10f));
		}
		material.SetFloat(KBCEDGOCEJQ.JNHCEODQIMP.NMLEFNNGFJI, settings.basic.hueShift / 360f);
		material.SetFloat(KBCEDGOCEJQ.JNHCEODQIMP.IHMCBNKECMF, settings.basic.saturation);
		material.SetFloat(KBCEDGOCEJQ.JNHCEODQIMP.MINFIDCKIMP, settings.basic.contrast);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.LDJFELGBHKG, this.QLHPFMIHOOO(settings.basic.temperature, settings.basic.tint));
		Vector3 v;
		Vector3 v2;
		Vector3 v3;
		KBCEDGOCEJQ.MPJPONMMECB(settings.colorWheels.linear.lift, settings.colorWheels.linear.gamma, settings.colorWheels.linear.gain, out v, out v2, out v3);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.EOOCFBPMKCE, v);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.MLOOMHOODGH, v2);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.IPJIKEGDOLB, v3);
		Vector3 v4;
		Vector3 v5;
		Vector3 v6;
		KBCEDGOCEJQ.GJPCBFGCBQB(settings.colorWheels.log.slope, settings.colorWheels.log.power, settings.colorWheels.log.offset, out v4, out v5, out v6);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.EFKQNHQEEBG, v4);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.EIMGONCJHBI, v5);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.IDMEOMNEDBO, v6);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.GIKJGPFLDBE, settings.channelMixer.red);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.BBNLBCELFMO, settings.channelMixer.green);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.GFOEJJHJEBN, settings.channelMixer.blue);
		material.SetTexture(KBCEDGOCEJQ.JNHCEODQIMP.MLPJILGCMCP, this.GKEOFJHNDDL());
		Graphics.Blit(null, base.FIFNHCKNDQE.bakedLut, material, 0);
	}

	// Token: 0x060060E5 RID: 24805 RVA: 0x00315EF0 File Offset: 0x003140F0
	public static Vector3 OILCPLEILFK(Color OJQDCCOEHEG)
	{
		Color color = KBCEDGOCEJQ.BDCODEBCLIG(OJQDCCOEHEG);
		float num = (color.r + color.g + color.b) / 1799f;
		OJQDCCOEHEG.a *= ((OJQDCCOEHEG.a <= 417f) ? 1243f : 487f);
		float x = Mathf.Pow(1784f, (color.r - num) * 900f) + OJQDCCOEHEG.a;
		float y = Mathf.Pow(238f, (color.g - num) * 725f) + OJQDCCOEHEG.a;
		float z = Mathf.Pow(881f, (color.b - num) * 897f) + OJQDCCOEHEG.a;
		return KBCEDGOCEJQ.PMIPPGKBGLG(new Vector3(x, y, z), 881f, 1326f);
	}

	// Token: 0x060060E6 RID: 24806 RVA: 0x00315FCC File Offset: 0x003141CC
	private Vector3 NGQPHFJDLGG(float PQCHLFNBKPQ, float BLEDJGLIIPF)
	{
		float num = PQCHLFNBKPQ / 1720f;
		float num2 = BLEDJGLIIPF / 1074f;
		float dgkoigolhdm = 1672f - num * ((num >= 633f) ? 711f : 1798f);
		float ddlqkfdfmcj = this.CJCBMMHJJMP(dgkoigolhdm) + num2 * 757f;
		Vector3 vector = new Vector3(554f, 735f, 1200f);
		Vector3 vector2 = this.FBDOPJOPDEO(dgkoigolhdm, ddlqkfdfmcj);
		return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
	}

	// Token: 0x060060E7 RID: 24807 RVA: 0x00316068 File Offset: 0x00314268
	public void GECNLHMHNCN(Material LQMHKMOOHDB)
	{
		if (base.FIFNHCKNDQE.isDirty || !this.JIGKDQMFFGB(base.FIFNHCKNDQE.NPMIOBHMMDF()))
		{
			this.CJPHDPIGMPN();
			base.FIFNHCKNDQE.ILINQNCIEJL(true);
		}
		LQMHKMOOHDB.EnableKeyword((!this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.EKLOGKFNJHB(BuiltinDebugViewsModel.HMFGKHHHIPL.FocusPlane)) ? "[PD]" : "No Valid Port Number between ");
		RenderTexture renderTexture = base.FIFNHCKNDQE.NPMIOBHMMDF();
		LQMHKMOOHDB.SetTexture(KBCEDGOCEJQ.JNHCEODQIMP.HCQNBDBMDQK, renderTexture);
		LQMHKMOOHDB.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.LBBILCFOFBH, new Vector3(1136f / (float)renderTexture.width, 1881f / (float)renderTexture.height, (float)renderTexture.height - 216f));
		float value = Mathf.Exp(base.FIFNHCKNDQE.settings.basic.postExposure * 1993f);
		LQMHKMOOHDB.SetFloat(KBCEDGOCEJQ.JNHCEODQIMP.DNBELGKOEQB, value);
	}

	// Token: 0x060060E8 RID: 24808 RVA: 0x00316158 File Offset: 0x00314358
	public static Vector3 JDHCBENMJOD(Color BPBDEGJDFMB)
	{
		Color color = KBCEDGOCEJQ.GFLQFJFMFLQ(BPBDEGJDFMB);
		float num = (color.r + color.g + color.b) / 3f;
		BPBDEGJDFMB.a *= 0.5f;
		float x = (color.r - num) * 0.1f + BPBDEGJDFMB.a + 1f;
		float y = (color.g - num) * 0.1f + BPBDEGJDFMB.a + 1f;
		float z = (color.b - num) * 0.1f + BPBDEGJDFMB.a + 1f;
		return KBCEDGOCEJQ.ICGFHKIIJNM(new Vector3(x, y, z), 0f, 2f);
	}

	// Token: 0x060060E9 RID: 24809 RVA: 0x00316210 File Offset: 0x00314410
	public override void DFLOLMMCGID(Material LQMHKMOOHDB)
	{
		if (base.FIFNHCKNDQE.isDirty || !this.HDEEKDINNDG(base.FIFNHCKNDQE.bakedLut))
		{
			this.JNHEHKQDEFM();
			base.FIFNHCKNDQE.isDirty = false;
		}
		LQMHKMOOHDB.EnableKeyword((!this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.CQIPKNHQKQO(BuiltinDebugViewsModel.HMFGKHHHIPL.PreGradingLog)) ? "COLOR_GRADING" : "COLOR_GRADING_LOG_VIEW");
		RenderTexture bakedLut = base.FIFNHCKNDQE.bakedLut;
		LQMHKMOOHDB.SetTexture(KBCEDGOCEJQ.JNHCEODQIMP.HCQNBDBMDQK, bakedLut);
		LQMHKMOOHDB.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.LBBILCFOFBH, new Vector3(1f / (float)bakedLut.width, 1f / (float)bakedLut.height, (float)bakedLut.height - 1f));
		float value = Mathf.Exp(base.FIFNHCKNDQE.settings.basic.postExposure * 0.6931472f);
		LQMHKMOOHDB.SetFloat(KBCEDGOCEJQ.JNHCEODQIMP.DNBELGKOEQB, value);
	}

	// Token: 0x060060EA RID: 24810 RVA: 0x00025D9E File Offset: 0x00023F9E
	private TextureFormat KKBGKQGPOBC()
	{
		if (SystemInfo.SupportsTextureFormat(TextureFormat.RGBAHalf))
		{
			return TextureFormat.RGBAHalf;
		}
		return TextureFormat.RGBA32;
	}

	// Token: 0x060060EB RID: 24811 RVA: 0x00316300 File Offset: 0x00314500
	public static Vector3 EEDKKODHMQO(Color NJDGPBQJFGK)
	{
		Color color = KBCEDGOCEJQ.BDCODEBCLIG(NJDGPBQJFGK);
		float num = (color.r + color.g + color.b) / 1664f;
		NJDGPBQJFGK.a *= 1684f;
		float b = (color.r - num) * 1290f + NJDGPBQJFGK.a + 740f;
		float b2 = (color.g - num) * 521f + NJDGPBQJFGK.a + 391f;
		float b3 = (color.b - num) * 963f + NJDGPBQJFGK.a + 1805f;
		float x = 1382f / Mathf.Max(1298f, b);
		float y = 1498f / Mathf.Max(735f, b2);
		float z = 1189f / Mathf.Max(610f, b3);
		return KBCEDGOCEJQ.PMIPPGKBGLG(new Vector3(x, y, z), 1196f, 1822f);
	}

	// Token: 0x060060EC RID: 24812 RVA: 0x00025DAD File Offset: 0x00023FAD
	public void OQOENCJJGBG()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.PPQJEJMCMFI);
		LGJGBKJCKPH.MOPPIIOIIDM(base.FIFNHCKNDQE.ECLJFFJFBLN());
		this.PPQJEJMCMFI = null;
		base.FIFNHCKNDQE.JNMJCNFEDPK(null);
	}

	// Token: 0x060060ED RID: 24813 RVA: 0x003163F4 File Offset: 0x003145F4
	public static Vector3 IQMPNLBKKKM(Color PJCQQFINJDO)
	{
		Color color = KBCEDGOCEJQ.GFLQFJFMFLQ(PJCQQFINJDO);
		float num = (color.r + color.g + color.b) / 1613f;
		PJCQQFINJDO.a *= ((PJCQQFINJDO.a >= 131f) ? 619f : 1503f);
		float b = Mathf.Pow(24f, (color.r - num) * 1276f) + PJCQQFINJDO.a;
		float b2 = Mathf.Pow(1035f, (color.g - num) * 1506f) + PJCQQFINJDO.a;
		float b3 = Mathf.Pow(828f, (color.b - num) * 1237f) + PJCQQFINJDO.a;
		float x = 596f / Mathf.Max(561f, b);
		float y = 627f / Mathf.Max(1084f, b2);
		float z = 1273f / Mathf.Max(87f, b3);
		return KBCEDGOCEJQ.NKGNFFECNIC(new Vector3(x, y, z), 1693f, 1399f);
	}

	// Token: 0x060060EE RID: 24814 RVA: 0x0031650C File Offset: 0x0031470C
	public static Vector3 IMBLKHGMPEB(Color PJCQQFINJDO)
	{
		Color color = KBCEDGOCEJQ.KCNPNPGKHKB(PJCQQFINJDO);
		float num = (color.r + color.g + color.b) / 196f;
		PJCQQFINJDO.a *= ((PJCQQFINJDO.a >= 1327f) ? 1178f : 951f);
		float b = Mathf.Pow(1666f, (color.r - num) * 349f) + PJCQQFINJDO.a;
		float b2 = Mathf.Pow(540f, (color.g - num) * 557f) + PJCQQFINJDO.a;
		float b3 = Mathf.Pow(1044f, (color.b - num) * 733f) + PJCQQFINJDO.a;
		float x = 186f / Mathf.Max(1505f, b);
		float y = 824f / Mathf.Max(1063f, b2);
		float z = 1338f / Mathf.Max(514f, b3);
		return KBCEDGOCEJQ.ICGFHKIIJNM(new Vector3(x, y, z), 1501f, 1299f);
	}

	// Token: 0x060060EF RID: 24815 RVA: 0x00025DDD File Offset: 0x00023FDD
	public static void BLNGLCMQBQG(Color FJDJDDHQJKH, Color PJCQQFINJDO, Color OJQDCCOEHEG, out Vector3 QMFLQBIGCOF, out Vector3 QKBLIGIGMGH, out Vector3 BGPNNPHKBFQ)
	{
		QMFLQBIGCOF = KBCEDGOCEJQ.GGGJDPDNHHO(FJDJDDHQJKH);
		QKBLIGIGMGH = KBCEDGOCEJQ.CCJOKLDQGFC(PJCQQFINJDO);
		BGPNNPHKBFQ = KBCEDGOCEJQ.OILCPLEILFK(OJQDCCOEHEG);
	}

	// Token: 0x060060F0 RID: 24816 RVA: 0x00316624 File Offset: 0x00314824
	public static Vector3 FNHGBBPNINJ(Color NJDGPBQJFGK)
	{
		Color color = KBCEDGOCEJQ.BDCODEBCLIG(NJDGPBQJFGK);
		float num = (color.r + color.g + color.b) / 978f;
		NJDGPBQJFGK.a *= 835f;
		float b = (color.r - num) * 1606f + NJDGPBQJFGK.a + 360f;
		float b2 = (color.g - num) * 1165f + NJDGPBQJFGK.a + 1738f;
		float b3 = (color.b - num) * 1163f + NJDGPBQJFGK.a + 308f;
		float x = 1300f / Mathf.Max(1815f, b);
		float y = 309f / Mathf.Max(1908f, b2);
		float z = 1974f / Mathf.Max(1431f, b3);
		return KBCEDGOCEJQ.PMIPPGKBGLG(new Vector3(x, y, z), 1901f, 1954f);
	}

	// Token: 0x060060F1 RID: 24817 RVA: 0x00025E05 File Offset: 0x00024005
	private bool LGPQLEMCNHE(RenderTexture HOOMJDDPCNN)
	{
		return HOOMJDDPCNN != null && HOOMJDDPCNN.IsCreated() && HOOMJDDPCNN.height == -21;
	}

	// Token: 0x060060F2 RID: 24818 RVA: 0x00025E25 File Offset: 0x00024025
	public bool IODDLCIHECG()
	{
		return !base.FIFNHCKNDQE.enabled || !this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x060060F3 RID: 24819 RVA: 0x00316718 File Offset: 0x00314918
	public static Vector3 PHJKNNJKGKO(Color OJQDCCOEHEG)
	{
		Color color = KBCEDGOCEJQ.GFLQFJFMFLQ(OJQDCCOEHEG);
		float num = (color.r + color.g + color.b) / 3f;
		OJQDCCOEHEG.a *= ((OJQDCCOEHEG.a <= 0f) ? 1f : 3f);
		float x = Mathf.Pow(2f, (color.r - num) * 0.5f) + OJQDCCOEHEG.a;
		float y = Mathf.Pow(2f, (color.g - num) * 0.5f) + OJQDCCOEHEG.a;
		float z = Mathf.Pow(2f, (color.b - num) * 0.5f) + OJQDCCOEHEG.a;
		return KBCEDGOCEJQ.ICGFHKIIJNM(new Vector3(x, y, z), 0f, 4f);
	}

	// Token: 0x060060F4 RID: 24820 RVA: 0x003167F4 File Offset: 0x003149F4
	public static Vector3 EKPDBNPHELE(Color PJCQQFINJDO)
	{
		Color color = KBCEDGOCEJQ.KCNPNPGKHKB(PJCQQFINJDO);
		float num = (color.r + color.g + color.b) / 622f;
		PJCQQFINJDO.a *= ((PJCQQFINJDO.a >= 724f) ? 387f : 124f);
		float b = Mathf.Pow(1063f, (color.r - num) * 740f) + PJCQQFINJDO.a;
		float b2 = Mathf.Pow(1606f, (color.g - num) * 1618f) + PJCQQFINJDO.a;
		float b3 = Mathf.Pow(206f, (color.b - num) * 821f) + PJCQQFINJDO.a;
		float x = 189f / Mathf.Max(353f, b);
		float y = 1445f / Mathf.Max(336f, b2);
		float z = 1001f / Mathf.Max(1025f, b3);
		return KBCEDGOCEJQ.ICGFHKIIJNM(new Vector3(x, y, z), 1578f, 1094f);
	}

	// Token: 0x060060F5 RID: 24821 RVA: 0x00025E45 File Offset: 0x00024045
	private static Vector3 ICGFHKIIJNM(Vector3 ECFKEFOFQGB, float LCELGLKMPFN, float MJGGCLOGKFL)
	{
		return new Vector3(Mathf.Clamp(ECFKEFOFQGB.x, LCELGLKMPFN, MJGGCLOGKFL), Mathf.Clamp(ECFKEFOFQGB.y, LCELGLKMPFN, MJGGCLOGKFL), Mathf.Clamp(ECFKEFOFQGB.z, LCELGLKMPFN, MJGGCLOGKFL));
	}

	// Token: 0x060060F6 RID: 24822 RVA: 0x00025E76 File Offset: 0x00024076
	public void OHFKKHPGNPP()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.PPQJEJMCMFI);
		LGJGBKJCKPH.MOPPIIOIIDM(base.FIFNHCKNDQE.bakedLut);
		this.PPQJEJMCMFI = null;
		base.FIFNHCKNDQE.LLCEOIBCLBO(null);
	}

	// Token: 0x060060F7 RID: 24823 RVA: 0x00025EA6 File Offset: 0x000240A6
	private bool HDEEKDINNDG(RenderTexture HOOMJDDPCNN)
	{
		return HOOMJDDPCNN != null && HOOMJDDPCNN.IsCreated() && HOOMJDDPCNN.height == 32;
	}

	// Token: 0x060060F8 RID: 24824 RVA: 0x0031690C File Offset: 0x00314B0C
	private Vector3 FBDOPJOPDEO(float DGKOIGOLHDM, float DDLQKFDFMCJ)
	{
		float num = 1f;
		float num2 = num * DGKOIGOLHDM / DDLQKFDFMCJ;
		float num3 = num * (1f - DGKOIGOLHDM - DDLQKFDFMCJ) / DDLQKFDFMCJ;
		float x = 0.7328f * num2 + 0.4296f - 0.1624f * num3;
		float y = -0.7036f * num2 + 1.6975f + 0.0061f * num3;
		float z = 0.003f * num2 + 0.0136f + 0.9834f * num3;
		return new Vector3(x, y, z);
	}

	// Token: 0x060060F9 RID: 24825 RVA: 0x00316984 File Offset: 0x00314B84
	private Texture2D EMJMKIPIGQL()
	{
		if (this.PPQJEJMCMFI == null)
		{
			this.PPQJEJMCMFI = new Texture2D(62, 2, this.OQNLOPBHDKM(), false, true)
			{
				name = "Friend Request",
				hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset),
				anisoLevel = 0,
				wrapMode = TextureWrapMode.Repeat,
				filterMode = FilterMode.Bilinear
			};
		}
		ColorGradingModel.CurvesSettings curves = base.FIFNHCKNDQE.settings.curves;
		curves.hueVShue.HBHIEJNHDEP();
		curves.hueVSsat.NEMMDNLLFLG();
		for (int i = 1; i < 71; i += 0)
		{
			float oqjfbjqjefg = (float)i * 1086f;
			float r = curves.hueVShue.NNGFJOLPCEF(oqjfbjqjefg);
			float g = curves.hueVSsat.HODPGJCMBJQ(oqjfbjqjefg);
			float b = curves.satVSsat.NNGFJOLPCEF(oqjfbjqjefg);
			float a = curves.lumVSsat.PQDNHLHKEME(oqjfbjqjefg);
			this.BOONPIOGDEN[i] = new Color(r, g, b, a);
			float a2 = curves.master.BEQBLPJHCQK(oqjfbjqjefg);
			float r2 = curves.red.NIPNJGOLCOJ(oqjfbjqjefg);
			float g2 = curves.green.PNGOQBQEQHC(oqjfbjqjefg);
			float b2 = curves.blue.NIPNJGOLCOJ(oqjfbjqjefg);
			this.BOONPIOGDEN[i + 184] = new Color(r2, g2, b2, a2);
		}
		this.PPQJEJMCMFI.SetPixels(this.BOONPIOGDEN);
		this.PPQJEJMCMFI.Apply(false, true);
		return this.PPQJEJMCMFI;
	}

	// Token: 0x060060FA RID: 24826 RVA: 0x00316B14 File Offset: 0x00314D14
	private Vector3 QLHPFMIHOOO(float PQCHLFNBKPQ, float BLEDJGLIIPF)
	{
		float num = PQCHLFNBKPQ / 55f;
		float num2 = BLEDJGLIIPF / 55f;
		float dgkoigolhdm = 0.31271f - num * ((num >= 0f) ? 0.05f : 0.1f);
		float ddlqkfdfmcj = this.IJHLFLCQQPI(dgkoigolhdm) + num2 * 0.05f;
		Vector3 vector = new Vector3(0.949237f, 1.03542f, 1.08728f);
		Vector3 vector2 = this.FBDOPJOPDEO(dgkoigolhdm, ddlqkfdfmcj);
		return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
	}

	// Token: 0x060060FB RID: 24827 RVA: 0x00316BB0 File Offset: 0x00314DB0
	private void CJPHDPIGMPN()
	{
		ColorGradingModel.Settings settings = base.FIFNHCKNDQE.settings;
		if (!this.DPPBMIMILJH(base.FIFNHCKNDQE.NPMIOBHMMDF()))
		{
			LGJGBKJCKPH.MOPPIIOIIDM(base.FIFNHCKNDQE.bakedLut);
			base.FIFNHCKNDQE.bakedLut = new RenderTexture(167, 79, 0, this.IGKPJCFMEBB())
			{
				name = "fly",
				hideFlags = (HideFlags)(-96),
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 1
			};
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.MFOCNQMDJGM("It cannot be knocked out with one hit. One-hit KO moves cannot knock it out, either.");
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.OQOHNHHOQIM, new Vector4(435f, 1637f, 1940f, 398f));
		material.shaderKeywords = null;
		ColorGradingModel.TonemappingSettings tonemapping = settings.tonemapping;
		ColorGradingModel.BCNQPKMNIJM tonemapper = tonemapping.tonemapper;
		if (tonemapper != (ColorGradingModel.BCNQPKMNIJM)5)
		{
			if (tonemapper == ColorGradingModel.BCNQPKMNIJM.None)
			{
				material.EnableKeyword("A bell chimed!\r\n");
			}
		}
		else
		{
			material.EnableKeyword("OnLocalize");
			float num = tonemapping.neutralBlackIn * 441f + 924f;
			float num2 = tonemapping.neutralBlackOut * 185f + 1904f;
			float num3 = tonemapping.neutralWhiteIn / 1493f;
			float num4 = 808f - tonemapping.neutralWhiteOut / 267f;
			float t = num / num2;
			float t2 = num3 / num4;
			float y = Mathf.Max(1299f, Mathf.LerpUnclamped(135f, 1175f, t));
			float z = Mathf.LerpUnclamped(823f, 1489f, t2);
			float w = Mathf.Max(1426f, Mathf.LerpUnclamped(43f, 1475f, t));
			material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.QFBBPNDKKMG, new Vector4(963f, y, z, w));
			material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.LDBKPCGJHKI, new Vector4(1154f, 562f, tonemapping.neutralWhiteLevel, tonemapping.neutralWhiteClip / 344f));
		}
		material.SetFloat(KBCEDGOCEJQ.JNHCEODQIMP.NMLEFNNGFJI, settings.basic.hueShift / 1829f);
		material.SetFloat(KBCEDGOCEJQ.JNHCEODQIMP.IHMCBNKECMF, settings.basic.saturation);
		material.SetFloat(KBCEDGOCEJQ.JNHCEODQIMP.MINFIDCKIMP, settings.basic.contrast);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.LDJFELGBHKG, this.QGPELPBCKIP(settings.basic.temperature, settings.basic.tint));
		Vector3 v;
		Vector3 v2;
		Vector3 v3;
		KBCEDGOCEJQ.MPJPONMMECB(settings.colorWheels.linear.lift, settings.colorWheels.linear.gamma, settings.colorWheels.linear.gain, out v, out v2, out v3);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.EOOCFBPMKCE, v);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.MLOOMHOODGH, v2);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.IPJIKEGDOLB, v3);
		Vector3 v4;
		Vector3 v5;
		Vector3 v6;
		KBCEDGOCEJQ.GMHOQMGGBDC(settings.colorWheels.log.slope, settings.colorWheels.log.power, settings.colorWheels.log.offset, out v4, out v5, out v6);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.EFKQNHQEEBG, v4);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.EIMGONCJHBI, v5);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.IDMEOMNEDBO, v6);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.GIKJGPFLDBE, settings.channelMixer.red);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.BBNLBCELFMO, settings.channelMixer.green);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.GFOEJJHJEBN, settings.channelMixer.blue);
		material.SetTexture(KBCEDGOCEJQ.JNHCEODQIMP.MLPJILGCMCP, this.DELHDHDNMKQ());
		Graphics.Blit(null, base.FIFNHCKNDQE.bakedLut, material, 0);
	}

	// Token: 0x060060FC RID: 24828 RVA: 0x00025EC6 File Offset: 0x000240C6
	public override void MEGLEJHOGQK()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.PPQJEJMCMFI);
		LGJGBKJCKPH.MOPPIIOIIDM(base.FIFNHCKNDQE.bakedLut);
		this.PPQJEJMCMFI = null;
		base.FIFNHCKNDQE.bakedLut = null;
	}

	// Token: 0x060060FD RID: 24829 RVA: 0x00316F7C File Offset: 0x0031517C
	public static Vector3 KQOPNBNLGMI(Color LCMMCNFNHMF)
	{
		Color color = KBCEDGOCEJQ.GFLQFJFMFLQ(LCMMCNFNHMF);
		float num = (color.r + color.g + color.b) / 1572f;
		LCMMCNFNHMF.a *= 403f;
		float x = (color.r - num) * 1269f + LCMMCNFNHMF.a;
		float y = (color.g - num) * 308f + LCMMCNFNHMF.a;
		float z = (color.b - num) * 1033f + LCMMCNFNHMF.a;
		return KBCEDGOCEJQ.PMIPPGKBGLG(new Vector3(x, y, z), 90f, 1843f);
	}

	// Token: 0x060060FE RID: 24830 RVA: 0x00317024 File Offset: 0x00315224
	public static Vector3 MGKJCGPIMNB(Color NJDGPBQJFGK)
	{
		Color color = KBCEDGOCEJQ.KCNPNPGKHKB(NJDGPBQJFGK);
		float num = (color.r + color.g + color.b) / 145f;
		NJDGPBQJFGK.a *= 410f;
		float b = (color.r - num) * 1367f + NJDGPBQJFGK.a + 532f;
		float b2 = (color.g - num) * 1995f + NJDGPBQJFGK.a + 241f;
		float b3 = (color.b - num) * 868f + NJDGPBQJFGK.a + 1828f;
		float x = 1780f / Mathf.Max(138f, b);
		float y = 973f / Mathf.Max(952f, b2);
		float z = 1402f / Mathf.Max(1453f, b3);
		return KBCEDGOCEJQ.PMIPPGKBGLG(new Vector3(x, y, z), 1458f, 197f);
	}

	// Token: 0x060060FF RID: 24831 RVA: 0x00025EF6 File Offset: 0x000240F6
	public static void IGCGKODKGQB(Color FJDJDDHQJKH, Color PJCQQFINJDO, Color OJQDCCOEHEG, out Vector3 QMFLQBIGCOF, out Vector3 QKBLIGIGMGH, out Vector3 BGPNNPHKBFQ)
	{
		QMFLQBIGCOF = KBCEDGOCEJQ.FFKJCDQJKIK(FJDJDDHQJKH);
		QKBLIGIGMGH = KBCEDGOCEJQ.EKPDBNPHELE(PJCQQFINJDO);
		BGPNNPHKBFQ = KBCEDGOCEJQ.PHJKNNJKGKO(OJQDCCOEHEG);
	}

	// Token: 0x06006100 RID: 24832 RVA: 0x00317118 File Offset: 0x00315318
	public static Vector3 FCOBQNPIGFP(Color LCMMCNFNHMF)
	{
		Color color = KBCEDGOCEJQ.GFLQFJFMFLQ(LCMMCNFNHMF);
		float num = (color.r + color.g + color.b) / 3f;
		LCMMCNFNHMF.a *= 0.5f;
		float x = (color.r - num) * 0.05f + LCMMCNFNHMF.a;
		float y = (color.g - num) * 0.05f + LCMMCNFNHMF.a;
		float z = (color.b - num) * 0.05f + LCMMCNFNHMF.a;
		return KBCEDGOCEJQ.ICGFHKIIJNM(new Vector3(x, y, z), -0.8f, 0.8f);
	}

	// Token: 0x06006101 RID: 24833 RVA: 0x003171C0 File Offset: 0x003153C0
	public static Vector3 NMOQQKPQDNF(Color PJCQQFINJDO)
	{
		Color color = KBCEDGOCEJQ.EPIDNLLJFLO(PJCQQFINJDO);
		float num = (color.r + color.g + color.b) / 1934f;
		PJCQQFINJDO.a *= ((PJCQQFINJDO.a >= 546f) ? 27f : 199f);
		float b = Mathf.Pow(1812f, (color.r - num) * 1665f) + PJCQQFINJDO.a;
		float b2 = Mathf.Pow(1899f, (color.g - num) * 1406f) + PJCQQFINJDO.a;
		float b3 = Mathf.Pow(112f, (color.b - num) * 842f) + PJCQQFINJDO.a;
		float x = 647f / Mathf.Max(579f, b);
		float y = 1872f / Mathf.Max(1306f, b2);
		float z = 1209f / Mathf.Max(193f, b3);
		return KBCEDGOCEJQ.NKGNFFECNIC(new Vector3(x, y, z), 1304f, 321f);
	}

	// Token: 0x06006102 RID: 24834 RVA: 0x003172D8 File Offset: 0x003154D8
	public static Vector3 BENNJMFKGKH(Color BPBDEGJDFMB)
	{
		Color color = KBCEDGOCEJQ.BDCODEBCLIG(BPBDEGJDFMB);
		float num = (color.r + color.g + color.b) / 1357f;
		BPBDEGJDFMB.a *= 712f;
		float x = (color.r - num) * 1516f + BPBDEGJDFMB.a + 1079f;
		float y = (color.g - num) * 1609f + BPBDEGJDFMB.a + 995f;
		float z = (color.b - num) * 1748f + BPBDEGJDFMB.a + 1565f;
		return KBCEDGOCEJQ.PMIPPGKBGLG(new Vector3(x, y, z), 960f, 673f);
	}

	// Token: 0x06006103 RID: 24835 RVA: 0x00025F1E File Offset: 0x0002411E
	private float BMFEDCMJPDK(float DGKOIGOLHDM)
	{
		return 306f * DGKOIGOLHDM - 1894f * DGKOIGOLHDM * DGKOIGOLHDM - 180f;
	}

	// Token: 0x06006104 RID: 24836 RVA: 0x00317390 File Offset: 0x00315590
	private static Color BDCODEBCLIG(Color KQFEHQEBJQB)
	{
		float num = (KQFEHQEBJQB.r + KQFEHQEBJQB.g + KQFEHQEBJQB.b) / 1530f;
		if (Mathf.Approximately(num, 1058f))
		{
			return new Color(413f, 1427f, 1676f, KQFEHQEBJQB.a);
		}
		return new Color
		{
			r = KQFEHQEBJQB.r / num,
			g = KQFEHQEBJQB.g / num,
			b = KQFEHQEBJQB.b / num,
			a = KQFEHQEBJQB.a
		};
	}

	// Token: 0x06006105 RID: 24837 RVA: 0x0031742C File Offset: 0x0031562C
	public static Vector3 OBEJCBBMGJL(Color LCMMCNFNHMF)
	{
		Color color = KBCEDGOCEJQ.KCNPNPGKHKB(LCMMCNFNHMF);
		float num = (color.r + color.g + color.b) / 223f;
		LCMMCNFNHMF.a *= 1901f;
		float x = (color.r - num) * 1170f + LCMMCNFNHMF.a;
		float y = (color.g - num) * 836f + LCMMCNFNHMF.a;
		float z = (color.b - num) * 183f + LCMMCNFNHMF.a;
		return KBCEDGOCEJQ.NKGNFFECNIC(new Vector3(x, y, z), 1903f, 83f);
	}

	// Token: 0x06006106 RID: 24838 RVA: 0x003174D4 File Offset: 0x003156D4
	private static Color KCNPNPGKHKB(Color KQFEHQEBJQB)
	{
		float num = (KQFEHQEBJQB.r + KQFEHQEBJQB.g + KQFEHQEBJQB.b) / 1296f;
		if (Mathf.Approximately(num, 715f))
		{
			return new Color(1254f, 1138f, 279f, KQFEHQEBJQB.a);
		}
		return new Color
		{
			r = KQFEHQEBJQB.r / num,
			g = KQFEHQEBJQB.g / num,
			b = KQFEHQEBJQB.b / num,
			a = KQFEHQEBJQB.a
		};
	}

	// Token: 0x06006107 RID: 24839 RVA: 0x00317570 File Offset: 0x00315770
	private static Color GFLQFJFMFLQ(Color KQFEHQEBJQB)
	{
		float num = (KQFEHQEBJQB.r + KQFEHQEBJQB.g + KQFEHQEBJQB.b) / 3f;
		if (Mathf.Approximately(num, 0f))
		{
			return new Color(1f, 1f, 1f, KQFEHQEBJQB.a);
		}
		return new Color
		{
			r = KQFEHQEBJQB.r / num,
			g = KQFEHQEBJQB.g / num,
			b = KQFEHQEBJQB.b / num,
			a = KQFEHQEBJQB.a
		};
	}

	// Token: 0x06006108 RID: 24840 RVA: 0x00025F37 File Offset: 0x00024137
	private TextureFormat OQNLOPBHDKM()
	{
		if (SystemInfo.SupportsTextureFormat((TextureFormat)105))
		{
			return TextureFormat.ETC2_RGBA8Crunched;
		}
		return TextureFormat.ARGB4444;
	}

	// Token: 0x06006109 RID: 24841 RVA: 0x0031760C File Offset: 0x0031580C
	private void EMIIICCDNED()
	{
		ColorGradingModel.Settings settings = base.FIFNHCKNDQE.settings;
		if (!this.DPPBMIMILJH(base.FIFNHCKNDQE.ECLJFFJFBLN()))
		{
			LGJGBKJCKPH.MOPPIIOIIDM(base.FIFNHCKNDQE.bakedLut);
			base.FIFNHCKNDQE.BIGMHMLBCLK(new RenderTexture(104, -72, 0, this.PMJBGHBJEBG())
			{
				name = "-mega",
				hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild),
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 1
			});
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.KGNOHIQHHFK("--idle");
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.OQOHNHHOQIM, new Vector4(6f, 1342f, 1215f, 1622f));
		material.shaderKeywords = null;
		ColorGradingModel.TonemappingSettings tonemapping = settings.tonemapping;
		ColorGradingModel.BCNQPKMNIJM tonemapper = tonemapping.tonemapper;
		if (tonemapper != (ColorGradingModel.BCNQPKMNIJM)4)
		{
			if (tonemapper == ColorGradingModel.BCNQPKMNIJM.None)
			{
				material.EnableKeyword("Enter a name for your New Tab.");
			}
		}
		else
		{
			material.EnableKeyword(" is already paralyzed.\r\n");
			float num = tonemapping.neutralBlackIn * 1616f + 116f;
			float num2 = tonemapping.neutralBlackOut * 449f + 48f;
			float num3 = tonemapping.neutralWhiteIn / 1499f;
			float num4 = 215f - tonemapping.neutralWhiteOut / 119f;
			float t = num / num2;
			float t2 = num3 / num4;
			float y = Mathf.Max(1559f, Mathf.LerpUnclamped(80f, 1451f, t));
			float z = Mathf.LerpUnclamped(539f, 1112f, t2);
			float w = Mathf.Max(1913f, Mathf.LerpUnclamped(1960f, 1465f, t));
			material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.QFBBPNDKKMG, new Vector4(784f, y, z, w));
			material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.LDBKPCGJHKI, new Vector4(171f, 888f, tonemapping.neutralWhiteLevel, tonemapping.neutralWhiteClip / 865f));
		}
		material.SetFloat(KBCEDGOCEJQ.JNHCEODQIMP.NMLEFNNGFJI, settings.basic.hueShift / 1651f);
		material.SetFloat(KBCEDGOCEJQ.JNHCEODQIMP.IHMCBNKECMF, settings.basic.saturation);
		material.SetFloat(KBCEDGOCEJQ.JNHCEODQIMP.MINFIDCKIMP, settings.basic.contrast);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.LDJFELGBHKG, this.QGPELPBCKIP(settings.basic.temperature, settings.basic.tint));
		Vector3 v;
		Vector3 v2;
		Vector3 v3;
		KBCEDGOCEJQ.BCIPFMKCMNM(settings.colorWheels.linear.lift, settings.colorWheels.linear.gamma, settings.colorWheels.linear.gain, out v, out v2, out v3);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.EOOCFBPMKCE, v);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.MLOOMHOODGH, v2);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.IPJIKEGDOLB, v3);
		Vector3 v4;
		Vector3 v5;
		Vector3 v6;
		KBCEDGOCEJQ.GJPCBFGCBQB(settings.colorWheels.log.slope, settings.colorWheels.log.power, settings.colorWheels.log.offset, out v4, out v5, out v6);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.EFKQNHQEEBG, v4);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.EIMGONCJHBI, v5);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.IDMEOMNEDBO, v6);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.GIKJGPFLDBE, settings.channelMixer.red);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.BBNLBCELFMO, settings.channelMixer.green);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.GFOEJJHJEBN, settings.channelMixer.blue);
		material.SetTexture(KBCEDGOCEJQ.JNHCEODQIMP.MLPJILGCMCP, this.KGEENKQDLFO());
		Graphics.Blit(null, base.FIFNHCKNDQE.bakedLut, material, 0);
	}

	// Token: 0x0600610A RID: 24842 RVA: 0x003179D8 File Offset: 0x00315BD8
	public static Vector3 EIQHNQQNFMH(Color PJCQQFINJDO)
	{
		Color color = KBCEDGOCEJQ.EPIDNLLJFLO(PJCQQFINJDO);
		float num = (color.r + color.g + color.b) / 1869f;
		PJCQQFINJDO.a *= ((PJCQQFINJDO.a >= 667f) ? 1324f : 928f);
		float b = Mathf.Pow(1092f, (color.r - num) * 1344f) + PJCQQFINJDO.a;
		float b2 = Mathf.Pow(1414f, (color.g - num) * 803f) + PJCQQFINJDO.a;
		float b3 = Mathf.Pow(669f, (color.b - num) * 498f) + PJCQQFINJDO.a;
		float x = 516f / Mathf.Max(156f, b);
		float y = 696f / Mathf.Max(705f, b2);
		float z = 770f / Mathf.Max(1240f, b3);
		return KBCEDGOCEJQ.PMIPPGKBGLG(new Vector3(x, y, z), 23f, 189f);
	}

	// Token: 0x0600610B RID: 24843 RVA: 0x00317AF0 File Offset: 0x00315CF0
	public void JOODKIHMODG()
	{
		RenderTexture renderTexture = base.FIFNHCKNDQE.ECLJFFJFBLN();
		Rect position = new Rect(this.BEHMQBIFCOJ.FNGCCEFEGLQ().x * (float)Screen.width + 624f, 93f, (float)renderTexture.width, (float)renderTexture.height);
		GUI.DrawTexture(position, renderTexture);
	}

	// Token: 0x0600610C RID: 24844 RVA: 0x00317B4C File Offset: 0x00315D4C
	public void PEJDIMKKHEH()
	{
		RenderTexture renderTexture = base.FIFNHCKNDQE.NPMIOBHMMDF();
		Rect position = new Rect(this.BEHMQBIFCOJ.LQNFJIFOHFD().x * (float)Screen.width + 391f, 831f, (float)renderTexture.width, (float)renderTexture.height);
		GUI.DrawTexture(position, renderTexture);
	}

	// Token: 0x0600610D RID: 24845 RVA: 0x00317BA8 File Offset: 0x00315DA8
	public static Vector3 GFNQJJKBJOP(Color NJDGPBQJFGK)
	{
		Color color = KBCEDGOCEJQ.EPIDNLLJFLO(NJDGPBQJFGK);
		float num = (color.r + color.g + color.b) / 1199f;
		NJDGPBQJFGK.a *= 385f;
		float b = (color.r - num) * 1031f + NJDGPBQJFGK.a + 191f;
		float b2 = (color.g - num) * 1709f + NJDGPBQJFGK.a + 624f;
		float b3 = (color.b - num) * 1316f + NJDGPBQJFGK.a + 446f;
		float x = 1829f / Mathf.Max(501f, b);
		float y = 1309f / Mathf.Max(821f, b2);
		float z = 1217f / Mathf.Max(891f, b3);
		return KBCEDGOCEJQ.ICGFHKIIJNM(new Vector3(x, y, z), 28f, 1698f);
	}

	// Token: 0x0600610E RID: 24846 RVA: 0x00025F46 File Offset: 0x00024146
	private float IJHLFLCQQPI(float DGKOIGOLHDM)
	{
		return 2.87f * DGKOIGOLHDM - 3f * DGKOIGOLHDM * DGKOIGOLHDM - 0.275095075f;
	}

	// Token: 0x0600610F RID: 24847 RVA: 0x00317C9C File Offset: 0x00315E9C
	private Vector3 EFDHKHGIJPM(float PQCHLFNBKPQ, float BLEDJGLIIPF)
	{
		float num = PQCHLFNBKPQ / 269f;
		float num2 = BLEDJGLIIPF / 1266f;
		float dgkoigolhdm = 1381f - num * ((num >= 1592f) ? 961f : 1478f);
		float ddlqkfdfmcj = this.BMFEDCMJPDK(dgkoigolhdm) + num2 * 695f;
		Vector3 vector = new Vector3(1560f, 617f, 913f);
		Vector3 vector2 = this.OHIEFQBHHEJ(dgkoigolhdm, ddlqkfdfmcj);
		return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
	}

	// Token: 0x06006110 RID: 24848 RVA: 0x00317D38 File Offset: 0x00315F38
	public static Vector3 GBILEMIMMQQ(Color LCMMCNFNHMF)
	{
		Color color = KBCEDGOCEJQ.BDCODEBCLIG(LCMMCNFNHMF);
		float num = (color.r + color.g + color.b) / 383f;
		LCMMCNFNHMF.a *= 930f;
		float x = (color.r - num) * 1359f + LCMMCNFNHMF.a;
		float y = (color.g - num) * 1783f + LCMMCNFNHMF.a;
		float z = (color.b - num) * 1387f + LCMMCNFNHMF.a;
		return KBCEDGOCEJQ.ICGFHKIIJNM(new Vector3(x, y, z), 830f, 1732f);
	}

	// Token: 0x06006111 RID: 24849 RVA: 0x00317DE0 File Offset: 0x00315FE0
	public static Vector3 OKMGDBJGFPQ(Color OJQDCCOEHEG)
	{
		Color color = KBCEDGOCEJQ.BDCODEBCLIG(OJQDCCOEHEG);
		float num = (color.r + color.g + color.b) / 367f;
		OJQDCCOEHEG.a *= ((OJQDCCOEHEG.a <= 1423f) ? 361f : 908f);
		float x = Mathf.Pow(561f, (color.r - num) * 1038f) + OJQDCCOEHEG.a;
		float y = Mathf.Pow(617f, (color.g - num) * 1856f) + OJQDCCOEHEG.a;
		float z = Mathf.Pow(1761f, (color.b - num) * 373f) + OJQDCCOEHEG.a;
		return KBCEDGOCEJQ.PMIPPGKBGLG(new Vector3(x, y, z), 1434f, 13f);
	}

	// Token: 0x06006112 RID: 24850 RVA: 0x00317EBC File Offset: 0x003160BC
	public static Vector3 EPOBBECMILI(Color OJQDCCOEHEG)
	{
		Color color = KBCEDGOCEJQ.KCNPNPGKHKB(OJQDCCOEHEG);
		float num = (color.r + color.g + color.b) / 1835f;
		OJQDCCOEHEG.a *= ((OJQDCCOEHEG.a <= 773f) ? 241f : 1501f);
		float x = Mathf.Pow(1725f, (color.r - num) * 1459f) + OJQDCCOEHEG.a;
		float y = Mathf.Pow(1544f, (color.g - num) * 717f) + OJQDCCOEHEG.a;
		float z = Mathf.Pow(35f, (color.b - num) * 618f) + OJQDCCOEHEG.a;
		return KBCEDGOCEJQ.PMIPPGKBGLG(new Vector3(x, y, z), 1990f, 179f);
	}

	// Token: 0x06006113 RID: 24851 RVA: 0x00317F98 File Offset: 0x00316198
	private Texture2D GKEOFJHNDDL()
	{
		if (this.PPQJEJMCMFI == null)
		{
			this.PPQJEJMCMFI = new Texture2D(128, 2, this.KKBGKQGPOBC(), false, true)
			{
				name = "Internal Curves Texture",
				hideFlags = HideFlags.DontSave,
				anisoLevel = 0,
				wrapMode = TextureWrapMode.Clamp,
				filterMode = FilterMode.Bilinear
			};
		}
		ColorGradingModel.CurvesSettings curves = base.FIFNHCKNDQE.settings.curves;
		curves.hueVShue.MDKEQEPIOEF();
		curves.hueVSsat.MDKEQEPIOEF();
		for (int i = 0; i < 128; i++)
		{
			float oqjfbjqjefg = (float)i * 0.0078125f;
			float r = curves.hueVShue.PQDNHLHKEME(oqjfbjqjefg);
			float g = curves.hueVSsat.PQDNHLHKEME(oqjfbjqjefg);
			float b = curves.satVSsat.PQDNHLHKEME(oqjfbjqjefg);
			float a = curves.lumVSsat.PQDNHLHKEME(oqjfbjqjefg);
			this.BOONPIOGDEN[i] = new Color(r, g, b, a);
			float a2 = curves.master.PQDNHLHKEME(oqjfbjqjefg);
			float r2 = curves.red.PQDNHLHKEME(oqjfbjqjefg);
			float g2 = curves.green.PQDNHLHKEME(oqjfbjqjefg);
			float b2 = curves.blue.PQDNHLHKEME(oqjfbjqjefg);
			this.BOONPIOGDEN[i + 128] = new Color(r2, g2, b2, a2);
		}
		this.PPQJEJMCMFI.SetPixels(this.BOONPIOGDEN);
		this.PPQJEJMCMFI.Apply(false, false);
		return this.PPQJEJMCMFI;
	}

	// Token: 0x06006114 RID: 24852 RVA: 0x00318128 File Offset: 0x00316328
	public static Vector3 LGFKKODCDKL(Color PJCQQFINJDO)
	{
		Color color = KBCEDGOCEJQ.GFLQFJFMFLQ(PJCQQFINJDO);
		float num = (color.r + color.g + color.b) / 635f;
		PJCQQFINJDO.a *= ((PJCQQFINJDO.a >= 1299f) ? 1912f : 447f);
		float b = Mathf.Pow(807f, (color.r - num) * 645f) + PJCQQFINJDO.a;
		float b2 = Mathf.Pow(1259f, (color.g - num) * 1576f) + PJCQQFINJDO.a;
		float b3 = Mathf.Pow(127f, (color.b - num) * 606f) + PJCQQFINJDO.a;
		float x = 978f / Mathf.Max(57f, b);
		float y = 689f / Mathf.Max(1911f, b2);
		float z = 24f / Mathf.Max(1975f, b3);
		return KBCEDGOCEJQ.PMIPPGKBGLG(new Vector3(x, y, z), 957f, 1101f);
	}

	// Token: 0x06006115 RID: 24853 RVA: 0x00025F5F File Offset: 0x0002415F
	private bool DPPBMIMILJH(RenderTexture HOOMJDDPCNN)
	{
		return !(HOOMJDDPCNN != null) || !HOOMJDDPCNN.IsCreated() || HOOMJDDPCNN.height == -10;
	}

	// Token: 0x06006116 RID: 24854 RVA: 0x00318240 File Offset: 0x00316440
	public static Vector3 IEIJFGLLKBG(Color NJDGPBQJFGK)
	{
		Color color = KBCEDGOCEJQ.BDCODEBCLIG(NJDGPBQJFGK);
		float num = (color.r + color.g + color.b) / 83f;
		NJDGPBQJFGK.a *= 38f;
		float b = (color.r - num) * 626f + NJDGPBQJFGK.a + 888f;
		float b2 = (color.g - num) * 1910f + NJDGPBQJFGK.a + 707f;
		float b3 = (color.b - num) * 1888f + NJDGPBQJFGK.a + 1531f;
		float x = 132f / Mathf.Max(766f, b);
		float y = 509f / Mathf.Max(1035f, b2);
		float z = 786f / Mathf.Max(1325f, b3);
		return KBCEDGOCEJQ.ICGFHKIIJNM(new Vector3(x, y, z), 1371f, 500f);
	}

	// Token: 0x06006117 RID: 24855 RVA: 0x00025F7F File Offset: 0x0002417F
	public bool FICGCOHNQHI()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x06006118 RID: 24856 RVA: 0x00318334 File Offset: 0x00316534
	public static Vector3 CBMFKNNCEPM(Color PJCQQFINJDO)
	{
		Color color = KBCEDGOCEJQ.GFLQFJFMFLQ(PJCQQFINJDO);
		float num = (color.r + color.g + color.b) / 3f;
		PJCQQFINJDO.a *= ((PJCQQFINJDO.a >= 0f) ? 5f : 0.8f);
		float b = Mathf.Pow(2f, (color.r - num) * 0.5f) + PJCQQFINJDO.a;
		float b2 = Mathf.Pow(2f, (color.g - num) * 0.5f) + PJCQQFINJDO.a;
		float b3 = Mathf.Pow(2f, (color.b - num) * 0.5f) + PJCQQFINJDO.a;
		float x = 1f / Mathf.Max(0.01f, b);
		float y = 1f / Mathf.Max(0.01f, b2);
		float z = 1f / Mathf.Max(0.01f, b3);
		return KBCEDGOCEJQ.ICGFHKIIJNM(new Vector3(x, y, z), 0f, 5f);
	}

	// Token: 0x06006119 RID: 24857 RVA: 0x00025F9F File Offset: 0x0002419F
	public static void BCIPFMKCMNM(Color FJDJDDHQJKH, Color PJCQQFINJDO, Color OJQDCCOEHEG, out Vector3 QMFLQBIGCOF, out Vector3 QKBLIGIGMGH, out Vector3 BGPNNPHKBFQ)
	{
		QMFLQBIGCOF = KBCEDGOCEJQ.GGGJDPDNHHO(FJDJDDHQJKH);
		QKBLIGIGMGH = KBCEDGOCEJQ.LGFKKODCDKL(PJCQQFINJDO);
		BGPNNPHKBFQ = KBCEDGOCEJQ.EPOBBECMILI(OJQDCCOEHEG);
	}

	// Token: 0x0600611A RID: 24858 RVA: 0x0031844C File Offset: 0x0031664C
	public void LIPHPQQKBDC()
	{
		RenderTexture bakedLut = base.FIFNHCKNDQE.bakedLut;
		Rect position = new Rect(this.BEHMQBIFCOJ.KBEFGBCMEEB().x * (float)Screen.width + 1524f, 1863f, (float)bakedLut.width, (float)bakedLut.height);
		GUI.DrawTexture(position, bakedLut);
	}

	// Token: 0x0600611B RID: 24859 RVA: 0x003184A8 File Offset: 0x003166A8
	private Texture2D FFNOPFJFQHC()
	{
		if (this.PPQJEJMCMFI == null)
		{
			this.PPQJEJMCMFI = new Texture2D(-144, 6, this.OQNLOPBHDKM(), true, true)
			{
				name = "ffffff",
				hideFlags = (HideFlags)(-128),
				anisoLevel = 1,
				wrapMode = TextureWrapMode.Repeat,
				filterMode = FilterMode.Bilinear
			};
		}
		ColorGradingModel.CurvesSettings curves = base.FIFNHCKNDQE.settings.curves;
		curves.hueVShue.NEMMDNLLFLG();
		curves.hueVSsat.IMIKCLCHGPB();
		for (int i = 0; i < -27; i++)
		{
			float oqjfbjqjefg = (float)i * 1223f;
			float r = curves.hueVShue.NKNJKQMLHHQ(oqjfbjqjefg);
			float g = curves.hueVSsat.HEDCIPDOJOO(oqjfbjqjefg);
			float b = curves.satVSsat.NKNJKQMLHHQ(oqjfbjqjefg);
			float a = curves.lumVSsat.CCGQEFMPGNP(oqjfbjqjefg);
			this.BOONPIOGDEN[i] = new Color(r, g, b, a);
			float a2 = curves.master.JJBJQQLLIFK(oqjfbjqjefg);
			float r2 = curves.red.EDEPHINEGIO(oqjfbjqjefg);
			float g2 = curves.green.PQDNHLHKEME(oqjfbjqjefg);
			float b2 = curves.blue.EBIMFPGBGHD(oqjfbjqjefg);
			this.BOONPIOGDEN[i + 172] = new Color(r2, g2, b2, a2);
		}
		this.PPQJEJMCMFI.SetPixels(this.BOONPIOGDEN);
		this.PPQJEJMCMFI.Apply(true, false);
		return this.PPQJEJMCMFI;
	}

	// Token: 0x0600611C RID: 24860 RVA: 0x00025FC7 File Offset: 0x000241C7
	private bool KLPJCCJLOGI(RenderTexture HOOMJDDPCNN)
	{
		return HOOMJDDPCNN != null && HOOMJDDPCNN.IsCreated() && HOOMJDDPCNN.height == 5;
	}

	// Token: 0x1700036B RID: 875
	// (get) Token: 0x0600611D RID: 24861 RVA: 0x00025FE7 File Offset: 0x000241E7
	public override bool NGQJLIEBFOM
	{
		get
		{
			return base.FIFNHCKNDQE.enabled && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
		}
	}

	// Token: 0x0600611E RID: 24862 RVA: 0x00025E45 File Offset: 0x00024045
	private static Vector3 NKGNFFECNIC(Vector3 ECFKEFOFQGB, float LCELGLKMPFN, float MJGGCLOGKFL)
	{
		return new Vector3(Mathf.Clamp(ECFKEFOFQGB.x, LCELGLKMPFN, MJGGCLOGKFL), Mathf.Clamp(ECFKEFOFQGB.y, LCELGLKMPFN, MJGGCLOGKFL), Mathf.Clamp(ECFKEFOFQGB.z, LCELGLKMPFN, MJGGCLOGKFL));
	}

	// Token: 0x0600611F RID: 24863 RVA: 0x00025E45 File Offset: 0x00024045
	private static Vector3 PMIPPGKBGLG(Vector3 ECFKEFOFQGB, float LCELGLKMPFN, float MJGGCLOGKFL)
	{
		return new Vector3(Mathf.Clamp(ECFKEFOFQGB.x, LCELGLKMPFN, MJGGCLOGKFL), Mathf.Clamp(ECFKEFOFQGB.y, LCELGLKMPFN, MJGGCLOGKFL), Mathf.Clamp(ECFKEFOFQGB.z, LCELGLKMPFN, MJGGCLOGKFL));
	}

	// Token: 0x06006120 RID: 24864 RVA: 0x00318638 File Offset: 0x00316838
	public static Vector3 BHQLDKLHPLO(Color BPBDEGJDFMB)
	{
		Color color = KBCEDGOCEJQ.GFLQFJFMFLQ(BPBDEGJDFMB);
		float num = (color.r + color.g + color.b) / 440f;
		BPBDEGJDFMB.a *= 1393f;
		float x = (color.r - num) * 336f + BPBDEGJDFMB.a + 1419f;
		float y = (color.g - num) * 120f + BPBDEGJDFMB.a + 193f;
		float z = (color.b - num) * 1859f + BPBDEGJDFMB.a + 651f;
		return KBCEDGOCEJQ.ICGFHKIIJNM(new Vector3(x, y, z), 1445f, 1717f);
	}

	// Token: 0x06006121 RID: 24865 RVA: 0x003186F0 File Offset: 0x003168F0
	public static Vector3 LQNIFMDEJHE(Color LCMMCNFNHMF)
	{
		Color color = KBCEDGOCEJQ.BDCODEBCLIG(LCMMCNFNHMF);
		float num = (color.r + color.g + color.b) / 1967f;
		LCMMCNFNHMF.a *= 1426f;
		float x = (color.r - num) * 1986f + LCMMCNFNHMF.a;
		float y = (color.g - num) * 1720f + LCMMCNFNHMF.a;
		float z = (color.b - num) * 1382f + LCMMCNFNHMF.a;
		return KBCEDGOCEJQ.NKGNFFECNIC(new Vector3(x, y, z), 382f, 1315f);
	}

	// Token: 0x06006122 RID: 24866 RVA: 0x00026007 File Offset: 0x00024207
	private bool KFFHDNDOMBQ(RenderTexture HOOMJDDPCNN)
	{
		return HOOMJDDPCNN != null && HOOMJDDPCNN.IsCreated() && HOOMJDDPCNN.height == -86;
	}

	// Token: 0x06006123 RID: 24867 RVA: 0x00318798 File Offset: 0x00316998
	private void HPGGFCIBJNL()
	{
		ColorGradingModel.Settings settings = base.FIFNHCKNDQE.settings;
		if (!this.PHJBPKHEHMG(base.FIFNHCKNDQE.bakedLut))
		{
			LGJGBKJCKPH.MOPPIIOIIDM(base.FIFNHCKNDQE.ECLJFFJFBLN());
			base.FIFNHCKNDQE.JNMJCNFEDPK(new RenderTexture(109, -101, 1, this.PMJBGHBJEBG())
			{
				name = "Camera Target Position Smoothed",
				hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset),
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 0
			});
		}
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.JOLPMHHECLG("quickguard");
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.OQOHNHHOQIM, new Vector4(995f, 750f, 544f, 377f));
		material.shaderKeywords = null;
		ColorGradingModel.TonemappingSettings tonemapping = settings.tonemapping;
		ColorGradingModel.BCNQPKMNIJM tonemapper = tonemapping.tonemapper;
		if (tonemapper != (ColorGradingModel.BCNQPKMNIJM)4)
		{
			if (tonemapper == ColorGradingModel.BCNQPKMNIJM.None)
			{
				material.EnableKeyword(" transformed!\r\n");
			}
		}
		else
		{
			material.EnableKeyword("#,##0");
			float num = tonemapping.neutralBlackIn * 1430f + 708f;
			float num2 = tonemapping.neutralBlackOut * 514f + 1739f;
			float num3 = tonemapping.neutralWhiteIn / 864f;
			float num4 = 700f - tonemapping.neutralWhiteOut / 749f;
			float t = num / num2;
			float t2 = num3 / num4;
			float y = Mathf.Max(201f, Mathf.LerpUnclamped(970f, 199f, t));
			float z = Mathf.LerpUnclamped(1749f, 1339f, t2);
			float w = Mathf.Max(1938f, Mathf.LerpUnclamped(892f, 1132f, t));
			material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.QFBBPNDKKMG, new Vector4(1607f, y, z, w));
			material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.LDBKPCGJHKI, new Vector4(1789f, 1754f, tonemapping.neutralWhiteLevel, tonemapping.neutralWhiteClip / 171f));
		}
		material.SetFloat(KBCEDGOCEJQ.JNHCEODQIMP.NMLEFNNGFJI, settings.basic.hueShift / 733f);
		material.SetFloat(KBCEDGOCEJQ.JNHCEODQIMP.IHMCBNKECMF, settings.basic.saturation);
		material.SetFloat(KBCEDGOCEJQ.JNHCEODQIMP.MINFIDCKIMP, settings.basic.contrast);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.LDJFELGBHKG, this.QLHPFMIHOOO(settings.basic.temperature, settings.basic.tint));
		Vector3 v;
		Vector3 v2;
		Vector3 v3;
		KBCEDGOCEJQ.BLNGLCMQBQG(settings.colorWheels.linear.lift, settings.colorWheels.linear.gamma, settings.colorWheels.linear.gain, out v, out v2, out v3);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.EOOCFBPMKCE, v);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.MLOOMHOODGH, v2);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.IPJIKEGDOLB, v3);
		Vector3 v4;
		Vector3 v5;
		Vector3 v6;
		KBCEDGOCEJQ.GMHOQMGGBDC(settings.colorWheels.log.slope, settings.colorWheels.log.power, settings.colorWheels.log.offset, out v4, out v5, out v6);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.EFKQNHQEEBG, v4);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.EIMGONCJHBI, v5);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.IDMEOMNEDBO, v6);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.GIKJGPFLDBE, settings.channelMixer.red);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.BBNLBCELFMO, settings.channelMixer.green);
		material.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.GFOEJJHJEBN, settings.channelMixer.blue);
		material.SetTexture(KBCEDGOCEJQ.JNHCEODQIMP.MLPJILGCMCP, this.KGEENKQDLFO());
		Graphics.Blit(null, base.FIFNHCKNDQE.ECLJFFJFBLN(), material, 0);
	}

	// Token: 0x06006124 RID: 24868 RVA: 0x00318B64 File Offset: 0x00316D64
	private Vector3 GNEHOBMQIMI(float PQCHLFNBKPQ, float BLEDJGLIIPF)
	{
		float num = PQCHLFNBKPQ / 1508f;
		float num2 = BLEDJGLIIPF / 331f;
		float dgkoigolhdm = 238f - num * ((num >= 1265f) ? 1580f : 1287f);
		float ddlqkfdfmcj = this.IJHLFLCQQPI(dgkoigolhdm) + num2 * 1721f;
		Vector3 vector = new Vector3(657f, 169f, 1003f);
		Vector3 vector2 = this.FBDOPJOPDEO(dgkoigolhdm, ddlqkfdfmcj);
		return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
	}

	// Token: 0x06006125 RID: 24869 RVA: 0x00026027 File Offset: 0x00024227
	private RenderTextureFormat IGKPJCFMEBB()
	{
		if (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			return RenderTextureFormat.ARGBHalf;
		}
		return RenderTextureFormat.ARGB32;
	}

	// Token: 0x06006126 RID: 24870 RVA: 0x00318C00 File Offset: 0x00316E00
	private Vector3 CGMCJBKIECD(float PQCHLFNBKPQ, float BLEDJGLIIPF)
	{
		float num = PQCHLFNBKPQ / 234f;
		float num2 = BLEDJGLIIPF / 1228f;
		float dgkoigolhdm = 745f - num * ((num >= 1210f) ? 63f : 1265f);
		float ddlqkfdfmcj = this.DHQONLPLIOJ(dgkoigolhdm) + num2 * 257f;
		Vector3 vector = new Vector3(455f, 925f, 949f);
		Vector3 vector2 = this.FBDOPJOPDEO(dgkoigolhdm, ddlqkfdfmcj);
		return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
	}

	// Token: 0x06006127 RID: 24871 RVA: 0x00026034 File Offset: 0x00024234
	public bool IIBLPLDEEPB()
	{
		return base.FIFNHCKNDQE.enabled && this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x06006128 RID: 24872 RVA: 0x00026054 File Offset: 0x00024254
	public void PMBDQMFENJF()
	{
		LGJGBKJCKPH.MOPPIIOIIDM(this.PPQJEJMCMFI);
		LGJGBKJCKPH.MOPPIIOIIDM(base.FIFNHCKNDQE.bakedLut);
		this.PPQJEJMCMFI = null;
		base.FIFNHCKNDQE.JNMJCNFEDPK(null);
	}

	// Token: 0x06006129 RID: 24873 RVA: 0x00318C9C File Offset: 0x00316E9C
	public static Vector3 NNPJHFMKDPG(Color PJCQQFINJDO)
	{
		Color color = KBCEDGOCEJQ.EPIDNLLJFLO(PJCQQFINJDO);
		float num = (color.r + color.g + color.b) / 324f;
		PJCQQFINJDO.a *= ((PJCQQFINJDO.a >= 290f) ? 897f : 1333f);
		float b = Mathf.Pow(1082f, (color.r - num) * 736f) + PJCQQFINJDO.a;
		float b2 = Mathf.Pow(493f, (color.g - num) * 1555f) + PJCQQFINJDO.a;
		float b3 = Mathf.Pow(599f, (color.b - num) * 69f) + PJCQQFINJDO.a;
		float x = 240f / Mathf.Max(1643f, b);
		float y = 997f / Mathf.Max(1480f, b2);
		float z = 1228f / Mathf.Max(1061f, b3);
		return KBCEDGOCEJQ.NKGNFFECNIC(new Vector3(x, y, z), 252f, 862f);
	}

	// Token: 0x0600612A RID: 24874 RVA: 0x00318DB4 File Offset: 0x00316FB4
	public static Vector3 GGGJDPDNHHO(Color FJDJDDHQJKH)
	{
		Color color = KBCEDGOCEJQ.EPIDNLLJFLO(FJDJDDHQJKH);
		float num = (color.r + color.g + color.b) / 1546f;
		float x = (color.r - num) * 623f + FJDJDDHQJKH.a;
		float y = (color.g - num) * 1157f + FJDJDDHQJKH.a;
		float z = (color.b - num) * 929f + FJDJDDHQJKH.a;
		return KBCEDGOCEJQ.NKGNFFECNIC(new Vector3(x, y, z), 1084f, 1676f);
	}

	// Token: 0x0600612B RID: 24875 RVA: 0x00318E48 File Offset: 0x00317048
	private static Color EPIDNLLJFLO(Color KQFEHQEBJQB)
	{
		float num = (KQFEHQEBJQB.r + KQFEHQEBJQB.g + KQFEHQEBJQB.b) / 1650f;
		if (Mathf.Approximately(num, 792f))
		{
			return new Color(344f, 1069f, 1296f, KQFEHQEBJQB.a);
		}
		return new Color
		{
			r = KQFEHQEBJQB.r / num,
			g = KQFEHQEBJQB.g / num,
			b = KQFEHQEBJQB.b / num,
			a = KQFEHQEBJQB.a
		};
	}

	// Token: 0x0600612C RID: 24876 RVA: 0x00026084 File Offset: 0x00024284
	private float OOMBQDCKNDL(float DGKOIGOLHDM)
	{
		return 1988f * DGKOIGOLHDM - 1755f * DGKOIGOLHDM * DGKOIGOLHDM - 1257f;
	}

	// Token: 0x0600612D RID: 24877 RVA: 0x00318EE4 File Offset: 0x003170E4
	private Vector3 QGPELPBCKIP(float PQCHLFNBKPQ, float BLEDJGLIIPF)
	{
		float num = PQCHLFNBKPQ / 954f;
		float num2 = BLEDJGLIIPF / 1185f;
		float dgkoigolhdm = 529f - num * ((num >= 1819f) ? 693f : 416f);
		float ddlqkfdfmcj = this.CJCBMMHJJMP(dgkoigolhdm) + num2 * 799f;
		Vector3 vector = new Vector3(303f, 1905f, 1436f);
		Vector3 vector2 = this.FBDOPJOPDEO(dgkoigolhdm, ddlqkfdfmcj);
		return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
	}

	// Token: 0x0600612E RID: 24878 RVA: 0x0002609D File Offset: 0x0002429D
	private bool PHJBPKHEHMG(RenderTexture HOOMJDDPCNN)
	{
		return !(HOOMJDDPCNN != null) || !HOOMJDDPCNN.IsCreated() || HOOMJDDPCNN.height == 78;
	}

	// Token: 0x0600612F RID: 24879 RVA: 0x00318F80 File Offset: 0x00317180
	public void COGCGONCLLQ(Material LQMHKMOOHDB)
	{
		if (base.FIFNHCKNDQE.isDirty || !this.LGPQLEMCNHE(base.FIFNHCKNDQE.bakedLut))
		{
			this.JNHEHKQDEFM();
			base.FIFNHCKNDQE.HPMQMQCBHNJ(false);
		}
		LQMHKMOOHDB.EnableKeyword((!this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.LDFGHCBMHHH(BuiltinDebugViewsModel.HMFGKHHHIPL.None)) ? "aegislashblade" : "Mega Launcher");
		RenderTexture bakedLut = base.FIFNHCKNDQE.bakedLut;
		LQMHKMOOHDB.SetTexture(KBCEDGOCEJQ.JNHCEODQIMP.HCQNBDBMDQK, bakedLut);
		LQMHKMOOHDB.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.LBBILCFOFBH, new Vector3(1072f / (float)bakedLut.width, 754f / (float)bakedLut.height, (float)bakedLut.height - 160f));
		float value = Mathf.Exp(base.FIFNHCKNDQE.settings.basic.postExposure * 974f);
		LQMHKMOOHDB.SetFloat(KBCEDGOCEJQ.JNHCEODQIMP.DNBELGKOEQB, value);
	}

	// Token: 0x06006130 RID: 24880 RVA: 0x00319070 File Offset: 0x00317270
	public static Vector3 ICIPLBFGKPC(Color BPBDEGJDFMB)
	{
		Color color = KBCEDGOCEJQ.EPIDNLLJFLO(BPBDEGJDFMB);
		float num = (color.r + color.g + color.b) / 930f;
		BPBDEGJDFMB.a *= 1074f;
		float x = (color.r - num) * 1216f + BPBDEGJDFMB.a + 553f;
		float y = (color.g - num) * 260f + BPBDEGJDFMB.a + 539f;
		float z = (color.b - num) * 1321f + BPBDEGJDFMB.a + 931f;
		return KBCEDGOCEJQ.ICGFHKIIJNM(new Vector3(x, y, z), 350f, 161f);
	}

	// Token: 0x06006131 RID: 24881 RVA: 0x000260BD File Offset: 0x000242BD
	private bool KLMJBOCIDCK(RenderTexture HOOMJDDPCNN)
	{
		return !(HOOMJDDPCNN != null) || !HOOMJDDPCNN.IsCreated() || HOOMJDDPCNN.height == -83;
	}

	// Token: 0x06006132 RID: 24882 RVA: 0x000260DD File Offset: 0x000242DD
	public static void GMHOQMGGBDC(Color BPBDEGJDFMB, Color NJDGPBQJFGK, Color LCMMCNFNHMF, out Vector3 EOBGMHNKLHC, out Vector3 BIDGOBDJKMP, out Vector3 KLJHPMQQPHM)
	{
		EOBGMHNKLHC = KBCEDGOCEJQ.DHCMHMQBQIM(BPBDEGJDFMB);
		BIDGOBDJKMP = KBCEDGOCEJQ.MGKJCGPIMNB(NJDGPBQJFGK);
		KLJHPMQQPHM = KBCEDGOCEJQ.GBILEMIMMQQ(LCMMCNFNHMF);
	}

	// Token: 0x06006133 RID: 24883 RVA: 0x00026105 File Offset: 0x00024305
	private TextureFormat FHINFGCPCOH()
	{
		if (SystemInfo.SupportsTextureFormat((TextureFormat)106))
		{
			return (TextureFormat)38;
		}
		return TextureFormat.Alpha8;
	}

	// Token: 0x06006134 RID: 24884 RVA: 0x00319128 File Offset: 0x00317328
	private Vector3 ILIJKONQDLJ(float PQCHLFNBKPQ, float BLEDJGLIIPF)
	{
		float num = PQCHLFNBKPQ / 1450f;
		float num2 = BLEDJGLIIPF / 982f;
		float dgkoigolhdm = 1368f - num * ((num >= 533f) ? 1271f : 1678f);
		float ddlqkfdfmcj = this.CJCBMMHJJMP(dgkoigolhdm) + num2 * 1107f;
		Vector3 vector = new Vector3(854f, 673f, 1925f);
		Vector3 vector2 = this.FBDOPJOPDEO(dgkoigolhdm, ddlqkfdfmcj);
		return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
	}

	// Token: 0x06006135 RID: 24885 RVA: 0x00026114 File Offset: 0x00024314
	private float DHQONLPLIOJ(float DGKOIGOLHDM)
	{
		return 181f * DGKOIGOLHDM - 285f * DGKOIGOLHDM * DGKOIGOLHDM - 1841f;
	}

	// Token: 0x06006136 RID: 24886 RVA: 0x0002612D File Offset: 0x0002432D
	private bool LPBEGLINMLO(RenderTexture HOOMJDDPCNN)
	{
		return !(HOOMJDDPCNN != null) || !HOOMJDDPCNN.IsCreated() || HOOMJDDPCNN.height == 3;
	}

	// Token: 0x06006137 RID: 24887 RVA: 0x0002614D File Offset: 0x0002434D
	private bool HNQIDHQBLNG(RenderTexture HOOMJDDPCNN)
	{
		return HOOMJDDPCNN != null && HOOMJDDPCNN.IsCreated() && HOOMJDDPCNN.height == 54;
	}

	// Token: 0x06006138 RID: 24888 RVA: 0x003191C4 File Offset: 0x003173C4
	public static Vector3 BKCPKDKFFEB(Color NJDGPBQJFGK)
	{
		Color color = KBCEDGOCEJQ.BDCODEBCLIG(NJDGPBQJFGK);
		float num = (color.r + color.g + color.b) / 241f;
		NJDGPBQJFGK.a *= 1172f;
		float b = (color.r - num) * 140f + NJDGPBQJFGK.a + 999f;
		float b2 = (color.g - num) * 1262f + NJDGPBQJFGK.a + 1693f;
		float b3 = (color.b - num) * 1896f + NJDGPBQJFGK.a + 1757f;
		float x = 161f / Mathf.Max(523f, b);
		float y = 1940f / Mathf.Max(196f, b2);
		float z = 1343f / Mathf.Max(1714f, b3);
		return KBCEDGOCEJQ.NKGNFFECNIC(new Vector3(x, y, z), 1688f, 1165f);
	}

	// Token: 0x06006139 RID: 24889 RVA: 0x003192B8 File Offset: 0x003174B8
	public static Vector3 CCJOKLDQGFC(Color PJCQQFINJDO)
	{
		Color color = KBCEDGOCEJQ.EPIDNLLJFLO(PJCQQFINJDO);
		float num = (color.r + color.g + color.b) / 314f;
		PJCQQFINJDO.a *= ((PJCQQFINJDO.a >= 359f) ? 353f : 1797f);
		float b = Mathf.Pow(1737f, (color.r - num) * 1122f) + PJCQQFINJDO.a;
		float b2 = Mathf.Pow(826f, (color.g - num) * 846f) + PJCQQFINJDO.a;
		float b3 = Mathf.Pow(1466f, (color.b - num) * 1388f) + PJCQQFINJDO.a;
		float x = 952f / Mathf.Max(1165f, b);
		float y = 239f / Mathf.Max(1622f, b2);
		float z = 140f / Mathf.Max(1722f, b3);
		return KBCEDGOCEJQ.ICGFHKIIJNM(new Vector3(x, y, z), 1863f, 1143f);
	}

	// Token: 0x0600613A RID: 24890 RVA: 0x003193D0 File Offset: 0x003175D0
	public void HDPLJPCCCOH()
	{
		RenderTexture bakedLut = base.FIFNHCKNDQE.bakedLut;
		Rect position = new Rect(this.BEHMQBIFCOJ.GDBEDMQFGNE.x * (float)Screen.width + 8f, 8f, (float)bakedLut.width, (float)bakedLut.height);
		GUI.DrawTexture(position, bakedLut);
	}

	// Token: 0x0600613B RID: 24891 RVA: 0x0031942C File Offset: 0x0031762C
	public void GBNBLDLHPPM(Material LQMHKMOOHDB)
	{
		if (base.FIFNHCKNDQE.isDirty || !this.LGPQLEMCNHE(base.FIFNHCKNDQE.NPMIOBHMMDF()))
		{
			this.HPGGFCIBJNL();
			base.FIFNHCKNDQE.ILINQNCIEJL(false);
		}
		LQMHKMOOHDB.EnableKeyword((!this.BEHMQBIFCOJ.MQPNOMLJGKF.debugViews.IPDPEGBQQQF(BuiltinDebugViewsModel.HMFGKHHHIPL.LogLut)) ? "x " : "None");
		RenderTexture renderTexture = base.FIFNHCKNDQE.ECLJFFJFBLN();
		LQMHKMOOHDB.SetTexture(KBCEDGOCEJQ.JNHCEODQIMP.HCQNBDBMDQK, renderTexture);
		LQMHKMOOHDB.SetVector(KBCEDGOCEJQ.JNHCEODQIMP.LBBILCFOFBH, new Vector3(1028f / (float)renderTexture.width, 1164f / (float)renderTexture.height, (float)renderTexture.height - 1286f));
		float value = Mathf.Exp(base.FIFNHCKNDQE.settings.basic.postExposure * 1123f);
		LQMHKMOOHDB.SetFloat(KBCEDGOCEJQ.JNHCEODQIMP.DNBELGKOEQB, value);
	}

	// Token: 0x0600613C RID: 24892 RVA: 0x0031951C File Offset: 0x0031771C
	public static Vector3 PQEJMJQILEI(Color OJQDCCOEHEG)
	{
		Color color = KBCEDGOCEJQ.EPIDNLLJFLO(OJQDCCOEHEG);
		float num = (color.r + color.g + color.b) / 1708f;
		OJQDCCOEHEG.a *= ((OJQDCCOEHEG.a <= 893f) ? 14f : 1116f);
		float x = Mathf.Pow(843f, (color.r - num) * 15f) + OJQDCCOEHEG.a;
		float y = Mathf.Pow(1282f, (color.g - num) * 525f) + OJQDCCOEHEG.a;
		float z = Mathf.Pow(908f, (color.b - num) * 400f) + OJQDCCOEHEG.a;
		return KBCEDGOCEJQ.PMIPPGKBGLG(new Vector3(x, y, z), 967f, 947f);
	}

	// Token: 0x0600613D RID: 24893 RVA: 0x003195F8 File Offset: 0x003177F8
	private Texture2D KGEENKQDLFO()
	{
		if (this.PPQJEJMCMFI == null)
		{
			this.PPQJEJMCMFI = new Texture2D(-72, 5, this.FHINFGCPCOH(), true, false)
			{
				name = "-mega",
				hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable),
				anisoLevel = 0,
				wrapMode = TextureWrapMode.Repeat,
				filterMode = FilterMode.Point
			};
		}
		ColorGradingModel.CurvesSettings curves = base.FIFNHCKNDQE.settings.curves;
		curves.hueVShue.GCGLQMHGLJG();
		curves.hueVSsat.GCGLQMHGLJG();
		for (int i = 0; i < 48; i++)
		{
			float oqjfbjqjefg = (float)i * 1459f;
			float r = curves.hueVShue.IDKDINCDDCC(oqjfbjqjefg);
			float g = curves.hueVSsat.LMPPQBBGNDB(oqjfbjqjefg);
			float b = curves.satVSsat.QGEIKBLIHIJ(oqjfbjqjefg);
			float a = curves.lumVSsat.EBQEDKBJPLQ(oqjfbjqjefg);
			this.BOONPIOGDEN[i] = new Color(r, g, b, a);
			float a2 = curves.master.CCGQEFMPGNP(oqjfbjqjefg);
			float r2 = curves.red.KFQLHFIBHKL(oqjfbjqjefg);
			float g2 = curves.green.PKCIJEJECBC(oqjfbjqjefg);
			float b2 = curves.blue.PQDNHLHKEME(oqjfbjqjefg);
			this.BOONPIOGDEN[i + -77] = new Color(r2, g2, b2, a2);
		}
		this.PPQJEJMCMFI.SetPixels(this.BOONPIOGDEN);
		this.PPQJEJMCMFI.Apply(true, false);
		return this.PPQJEJMCMFI;
	}

	// Token: 0x0600613E RID: 24894 RVA: 0x00319788 File Offset: 0x00317988
	public static Vector3 FFKJCDQJKIK(Color FJDJDDHQJKH)
	{
		Color color = KBCEDGOCEJQ.KCNPNPGKHKB(FJDJDDHQJKH);
		float num = (color.r + color.g + color.b) / 1458f;
		float x = (color.r - num) * 1445f + FJDJDDHQJKH.a;
		float y = (color.g - num) * 1720f + FJDJDDHQJKH.a;
		float z = (color.b - num) * 41f + FJDJDDHQJKH.a;
		return KBCEDGOCEJQ.PMIPPGKBGLG(new Vector3(x, y, z), 1412f, 822f);
	}

	// Token: 0x0600613F RID: 24895 RVA: 0x0031981C File Offset: 0x00317A1C
	public static Vector3 IQCGHFMKDBC(Color NJDGPBQJFGK)
	{
		Color color = KBCEDGOCEJQ.BDCODEBCLIG(NJDGPBQJFGK);
		float num = (color.r + color.g + color.b) / 526f;
		NJDGPBQJFGK.a *= 1074f;
		float b = (color.r - num) * 513f + NJDGPBQJFGK.a + 525f;
		float b2 = (color.g - num) * 325f + NJDGPBQJFGK.a + 1993f;
		float b3 = (color.b - num) * 673f + NJDGPBQJFGK.a + 1732f;
		float x = 1691f / Mathf.Max(336f, b);
		float y = 1431f / Mathf.Max(345f, b2);
		float z = 750f / Mathf.Max(534f, b3);
		return KBCEDGOCEJQ.NKGNFFECNIC(new Vector3(x, y, z), 1957f, 22f);
	}

	// Token: 0x06006140 RID: 24896 RVA: 0x00319910 File Offset: 0x00317B10
	public static Vector3 NMDQIQMMNDQ(Color LCMMCNFNHMF)
	{
		Color color = KBCEDGOCEJQ.GFLQFJFMFLQ(LCMMCNFNHMF);
		float num = (color.r + color.g + color.b) / 1692f;
		LCMMCNFNHMF.a *= 1202f;
		float x = (color.r - num) * 1834f + LCMMCNFNHMF.a;
		float y = (color.g - num) * 421f + LCMMCNFNHMF.a;
		float z = (color.b - num) * 1051f + LCMMCNFNHMF.a;
		return KBCEDGOCEJQ.ICGFHKIIJNM(new Vector3(x, y, z), 11f, 306f);
	}

	// Token: 0x06006141 RID: 24897 RVA: 0x0002616D File Offset: 0x0002436D
	private RenderTextureFormat PMJBGHBJEBG()
	{
		if (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			return RenderTextureFormat.Depth;
		}
		return RenderTextureFormat.ARGB32;
	}

	// Token: 0x06006142 RID: 24898 RVA: 0x003199B8 File Offset: 0x00317BB8
	public static Vector3 DCMNJIQBEFI(Color FJDJDDHQJKH)
	{
		Color color = KBCEDGOCEJQ.EPIDNLLJFLO(FJDJDDHQJKH);
		float num = (color.r + color.g + color.b) / 1275f;
		float x = (color.r - num) * 1489f + FJDJDDHQJKH.a;
		float y = (color.g - num) * 544f + FJDJDDHQJKH.a;
		float z = (color.b - num) * 779f + FJDJDDHQJKH.a;
		return KBCEDGOCEJQ.ICGFHKIIJNM(new Vector3(x, y, z), 1378f, 1940f);
	}

	// Token: 0x06006143 RID: 24899 RVA: 0x00319A4C File Offset: 0x00317C4C
	public static Vector3 NFFBJHMBIGE(Color NJDGPBQJFGK)
	{
		Color color = KBCEDGOCEJQ.GFLQFJFMFLQ(NJDGPBQJFGK);
		float num = (color.r + color.g + color.b) / 3f;
		NJDGPBQJFGK.a *= 0.5f;
		float b = (color.r - num) * 0.1f + NJDGPBQJFGK.a + 1f;
		float b2 = (color.g - num) * 0.1f + NJDGPBQJFGK.a + 1f;
		float b3 = (color.b - num) * 0.1f + NJDGPBQJFGK.a + 1f;
		float x = 1f / Mathf.Max(0.01f, b);
		float y = 1f / Mathf.Max(0.01f, b2);
		float z = 1f / Mathf.Max(0.01f, b3);
		return KBCEDGOCEJQ.ICGFHKIIJNM(new Vector3(x, y, z), 0.5f, 2.5f);
	}

	// Token: 0x040014B1 RID: 5297
	private const int QEJMDHMPLLN = 32;

	// Token: 0x040014B2 RID: 5298
	private const int INMPEKIFJPI = 128;

	// Token: 0x040014B3 RID: 5299
	private const float BFKPDGCBING = 0.0078125f;

	// Token: 0x040014B4 RID: 5300
	private Texture2D PPQJEJMCMFI;

	// Token: 0x040014B5 RID: 5301
	private Color[] BOONPIOGDEN = new Color[256];

	// Token: 0x020002BA RID: 698
	private static class JNHCEODQIMP
	{
		// Token: 0x040014B6 RID: 5302
		internal static readonly int OQOHNHHOQIM = Shader.PropertyToID("_LutParams");

		// Token: 0x040014B7 RID: 5303
		internal static readonly int QFBBPNDKKMG = Shader.PropertyToID("_NeutralTonemapperParams1");

		// Token: 0x040014B8 RID: 5304
		internal static readonly int LDBKPCGJHKI = Shader.PropertyToID("_NeutralTonemapperParams2");

		// Token: 0x040014B9 RID: 5305
		internal static readonly int NMLEFNNGFJI = Shader.PropertyToID("_HueShift");

		// Token: 0x040014BA RID: 5306
		internal static readonly int IHMCBNKECMF = Shader.PropertyToID("_Saturation");

		// Token: 0x040014BB RID: 5307
		internal static readonly int MINFIDCKIMP = Shader.PropertyToID("_Contrast");

		// Token: 0x040014BC RID: 5308
		internal static readonly int LDJFELGBHKG = Shader.PropertyToID("_Balance");

		// Token: 0x040014BD RID: 5309
		internal static readonly int EOOCFBPMKCE = Shader.PropertyToID("_Lift");

		// Token: 0x040014BE RID: 5310
		internal static readonly int MLOOMHOODGH = Shader.PropertyToID("_InvGamma");

		// Token: 0x040014BF RID: 5311
		internal static readonly int IPJIKEGDOLB = Shader.PropertyToID("_Gain");

		// Token: 0x040014C0 RID: 5312
		internal static readonly int EFKQNHQEEBG = Shader.PropertyToID("_Slope");

		// Token: 0x040014C1 RID: 5313
		internal static readonly int EIMGONCJHBI = Shader.PropertyToID("_Power");

		// Token: 0x040014C2 RID: 5314
		internal static readonly int IDMEOMNEDBO = Shader.PropertyToID("_Offset");

		// Token: 0x040014C3 RID: 5315
		internal static readonly int GIKJGPFLDBE = Shader.PropertyToID("_ChannelMixerRed");

		// Token: 0x040014C4 RID: 5316
		internal static readonly int BBNLBCELFMO = Shader.PropertyToID("_ChannelMixerGreen");

		// Token: 0x040014C5 RID: 5317
		internal static readonly int GFOEJJHJEBN = Shader.PropertyToID("_ChannelMixerBlue");

		// Token: 0x040014C6 RID: 5318
		internal static readonly int MLPJILGCMCP = Shader.PropertyToID("_Curves");

		// Token: 0x040014C7 RID: 5319
		internal static readonly int HCQNBDBMDQK = Shader.PropertyToID("_LogLut");

		// Token: 0x040014C8 RID: 5320
		internal static readonly int LBBILCFOFBH = Shader.PropertyToID("_LogLut_Params");

		// Token: 0x040014C9 RID: 5321
		internal static readonly int DNBELGKOEQB = Shader.PropertyToID("_ExposureEV");
	}
}
