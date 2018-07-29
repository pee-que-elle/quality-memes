using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x020002C3 RID: 707
public sealed class LJMJFHFGPJK : ONQQOCQBQIE<AntialiasingModel>
{
	// Token: 0x0600628E RID: 25230 RVA: 0x003227BC File Offset: 0x003209BC
	public bool FCEMOKHFPGI()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.ICEIQHLLNEL().method != AntialiasingModel.JONBCBGIHFH.Fxaa || this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x0600628F RID: 25231 RVA: 0x003227FC File Offset: 0x003209FC
	public bool DJINFDCBGKB()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.DNDPKMIFFDJ().method != AntialiasingModel.JONBCBGIHFH.Fxaa || this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x06006290 RID: 25232 RVA: 0x0032283C File Offset: 0x00320A3C
	public void JIPQNEPNBBO(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.DDCKCBDHLCL().fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.JOLPMHHECLG("Big/");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 1);
	}

	// Token: 0x06006291 RID: 25233 RVA: 0x00322904 File Offset: 0x00320B04
	public bool FICGCOHNQHI()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.DNDPKMIFFDJ().method == AntialiasingModel.JONBCBGIHFH.Fxaa && this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x06006292 RID: 25234 RVA: 0x00322944 File Offset: 0x00320B44
	public void CHQPHOGBBQI(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.EFKIKEPOEGP().fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.KGNOHIQHHFK("Passes through the opposing Pokémon's barrier, substitute, and the like and strikes.");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 0);
	}

	// Token: 0x06006293 RID: 25235 RVA: 0x00322A0C File Offset: 0x00320C0C
	public void DNPIFQIIDBJ(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.OEDHDNBPDLN().fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.PIHPPJNJDQC("door_5");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 0);
	}

	// Token: 0x06006294 RID: 25236 RVA: 0x00322AD4 File Offset: 0x00320CD4
	public void MIPOOOENPLG(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.ICEIQHLLNEL().fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.CCLFGNMOBMI("move: ");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 0);
	}

	// Token: 0x06006295 RID: 25237 RVA: 0x00322B9C File Offset: 0x00320D9C
	public void OBELJGBQGOC(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.HPEGEDJEFKF().fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.JOLPMHHECLG("Head");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 1);
	}

	// Token: 0x17000370 RID: 880
	// (get) Token: 0x06006296 RID: 25238 RVA: 0x00322C64 File Offset: 0x00320E64
	public override bool NGQJLIEBFOM
	{
		get
		{
			return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.settings.method == AntialiasingModel.JONBCBGIHFH.Fxaa && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
		}
	}

	// Token: 0x06006297 RID: 25239 RVA: 0x00322CA4 File Offset: 0x00320EA4
	public void BIPENHIDFOK(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.ICEIQHLLNEL().fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.GBBDHLKHEOO("A soothing aroma wafted through the area!\r\n");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 1);
	}

	// Token: 0x06006298 RID: 25240 RVA: 0x00322904 File Offset: 0x00320B04
	public bool EEEJKHJQBPL()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.DNDPKMIFFDJ().method == AntialiasingModel.JONBCBGIHFH.Fxaa && this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x06006299 RID: 25241 RVA: 0x00322D6C File Offset: 0x00320F6C
	public void NOODEMIFPPL(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.KNBMBCNPNLF().fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.PJJDFGJECLK("Dig Cooldown");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 0);
	}

	// Token: 0x0600629A RID: 25242 RVA: 0x00322E34 File Offset: 0x00321034
	public void CQNDDBEMIQD(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.DNDPKMIFFDJ().fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.MLLNLFQCMKQ("default");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 1);
	}

	// Token: 0x0600629B RID: 25243 RVA: 0x00322EFC File Offset: 0x003210FC
	public bool OCLNJQFCJOD()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.INPGLPEDINQ().method != AntialiasingModel.JONBCBGIHFH.Fxaa || !this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x0600629C RID: 25244 RVA: 0x00322F3C File Offset: 0x0032113C
	public bool GGBQICFGNGQ()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.OILMJDEQKHM().method == AntialiasingModel.JONBCBGIHFH.Fxaa && !this.BEHMQBIFCOJ.LKBIMLFLQHQ();
	}

	// Token: 0x0600629D RID: 25245 RVA: 0x00322F7C File Offset: 0x0032117C
	public void HKIKLLQJDNN(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.DNDPKMIFFDJ().fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.DHLOEEOKKCL("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=GUQ6ZWT36PWEC&custom=");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 0);
	}

	// Token: 0x0600629E RID: 25246 RVA: 0x00323044 File Offset: 0x00321244
	public void ILCMMJMCPIE(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.settings.fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("Hidden/Post FX/FXAA");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 0);
	}

	// Token: 0x0600629F RID: 25247 RVA: 0x0032310C File Offset: 0x0032130C
	public void KOGLCCNQJIC(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.LDKELCQOGJQ().fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("#");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 1);
	}

	// Token: 0x060062A0 RID: 25248 RVA: 0x003231D4 File Offset: 0x003213D4
	public void QNEQEMBHDDB(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.MBKBQDBIICQ().fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.DHLOEEOKKCL("RS");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 1);
	}

	// Token: 0x060062A1 RID: 25249 RVA: 0x0032329C File Offset: 0x0032149C
	public void DQOLCDKQBPB(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.DNDPKMIFFDJ().fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QDMHMMGFIOJ("Party");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 1);
	}

	// Token: 0x060062A2 RID: 25250 RVA: 0x00323364 File Offset: 0x00321564
	public bool FHFMFDQOEII()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.OLKBFBGKLKJ().method == AntialiasingModel.JONBCBGIHFH.Fxaa && this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x060062A3 RID: 25251 RVA: 0x003233A4 File Offset: 0x003215A4
	public void BHOIEOMQPIQ(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.DNDPKMIFFDJ().fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.DNKGKNNMFBC("whitesmoke");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 1);
	}

	// Token: 0x060062A4 RID: 25252 RVA: 0x0032346C File Offset: 0x0032166C
	public void LCIMIKLGLFK(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.DNDPKMIFFDJ().fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.DHLOEEOKKCL("(Ex)");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 0);
	}

	// Token: 0x060062A5 RID: 25253 RVA: 0x00323534 File Offset: 0x00321734
	public void JPEKQDIEDFH(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.EFKIKEPOEGP().fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.FJIJQOQKHGK("skyattack");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 0);
	}

	// Token: 0x060062A7 RID: 25255 RVA: 0x003235FC File Offset: 0x003217FC
	public bool MLIMGGOLOCO()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.OEDHDNBPDLN().method == AntialiasingModel.JONBCBGIHFH.Fxaa && this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x060062A8 RID: 25256 RVA: 0x0032363C File Offset: 0x0032183C
	public void MEFLCIJHNMH(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.MBKBQDBIICQ().fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.HFMKDHIIPNH("BuffIcon_EncounterRateDecreased");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 0);
	}

	// Token: 0x060062A9 RID: 25257 RVA: 0x00323704 File Offset: 0x00321904
	public void GMONMKQQFDO(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.DCPMJDLDNMM().fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.NJKNIOFBHBD("e");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 1);
	}

	// Token: 0x060062AA RID: 25258 RVA: 0x003237CC File Offset: 0x003219CC
	public void JGCPBQIGBNO(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.DCPMJDLDNMM().fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QJGFMDNNQLB("User");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 0);
	}

	// Token: 0x060062AB RID: 25259 RVA: 0x00323894 File Offset: 0x00321A94
	public bool DDPQKIGQKEE()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.KNBMBCNPNLF().method != AntialiasingModel.JONBCBGIHFH.Fxaa || this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x060062AC RID: 25260 RVA: 0x00323894 File Offset: 0x00321A94
	public bool NMLQJHEPGJO()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.KNBMBCNPNLF().method != AntialiasingModel.JONBCBGIHFH.Fxaa || this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x060062AD RID: 25261 RVA: 0x003238D4 File Offset: 0x00321AD4
	public bool JKGMHKINEOC()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.MBKBQDBIICQ().method == AntialiasingModel.JONBCBGIHFH.Fxaa && this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x060062AE RID: 25262 RVA: 0x00323914 File Offset: 0x00321B14
	public bool QGOCIIGQLFC()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.MBKBQDBIICQ().method != AntialiasingModel.JONBCBGIHFH.Fxaa || !this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x060062AF RID: 25263 RVA: 0x00323954 File Offset: 0x00321B54
	public void CIGKMBGDPKD(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.OEDHDNBPDLN().fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.MFOCNQMDJGM("Username already in use");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 0);
	}

	// Token: 0x060062B0 RID: 25264 RVA: 0x00323A1C File Offset: 0x00321C1C
	public bool INCHDBOKENQ()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.DCPMJDLDNMM().method == AntialiasingModel.JONBCBGIHFH.Fxaa && this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x060062B1 RID: 25265 RVA: 0x00323A5C File Offset: 0x00321C5C
	public void CQIMLJQJOBL(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		AntialiasingModel.FxaaSettings fxaaSettings = base.FIFNHCKNDQE.KNBMBCNPNLF().fxaaSettings;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.MFOCNQMDJGM("But it failed.\r\n");
		AntialiasingModel.FxaaQualitySettings fxaaQualitySettings = AntialiasingModel.FxaaQualitySettings.presets[(int)fxaaSettings.preset];
		AntialiasingModel.FxaaConsoleSettings fxaaConsoleSettings = AntialiasingModel.FxaaConsoleSettings.presets[(int)fxaaSettings.preset];
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.PMGGHFIFCBP, new Vector3(fxaaQualitySettings.subpixelAliasingRemovalAmount, fxaaQualitySettings.edgeDetectionThreshold, fxaaQualitySettings.minimumRequiredLuminance));
		material.SetVector(LJMJFHFGPJK.MBJIIOPQFBH.ONLJNOPKGJM, new Vector4(fxaaConsoleSettings.subpixelSpreadAmount, fxaaConsoleSettings.edgeSharpnessAmount, fxaaConsoleSettings.edgeDetectionThreshold, fxaaConsoleSettings.minimumRequiredLuminance));
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC, material, 1);
	}

	// Token: 0x020002C4 RID: 708
	private static class MBJIIOPQFBH
	{
		// Token: 0x040014F4 RID: 5364
		internal static readonly int PMGGHFIFCBP = Shader.PropertyToID("_QualitySettings");

		// Token: 0x040014F5 RID: 5365
		internal static readonly int ONLJNOPKGJM = Shader.PropertyToID("_ConsoleSettings");
	}
}
