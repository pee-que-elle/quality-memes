using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.Rendering;

// Token: 0x02000311 RID: 785
[ImageEffectAllowedInSceneView]
[RequireComponent(typeof(Camera))]
[DisallowMultipleComponent]
[ExecuteInEditMode]
[AddComponentMenu("Effects/Post-Processing Behaviour", -1)]
public class OKCGKHQHCGE : MonoBehaviour
{
	// Token: 0x060069B2 RID: 27058 RVA: 0x00027D7B File Offset: 0x00025F7B
	private bool QGCELBLJPHK<T>(ONQQOCQBQIE<T> EPOHMKPHHEM, Material PPLIPCEHGNM) where T : PostProcessingModel
	{
		if (!EPOHMKPHHEM.NGQJLIEBFOM)
		{
			return false;
		}
		EPOHMKPHHEM.DFLOLMMCGID(PPLIPCEHGNM);
		return true;
	}

	// Token: 0x060069B3 RID: 27059 RVA: 0x00344B90 File Offset: 0x00342D90
	private void GIOLKPFOOMD()
	{
		foreach (KeyValuePair<JBGLEFPOLGP, bool> keyValuePair in this.LHIGHGONHGQ)
		{
			JBGLEFPOLGP key = keyValuePair.Key;
			bool enabled;
			if ((enabled = key.CEKEFONEMIK().enabled) != keyValuePair.Value)
			{
				if (enabled)
				{
					this.JQIPPDCFBIK.Add(key);
				}
				else
				{
					this.KMFNKJIDLBP.Add(key);
				}
			}
		}
		for (int i = 0; i < this.KMFNKJIDLBP.Count; i += 0)
		{
			JBGLEFPOLGP jbglefpolgp = this.KMFNKJIDLBP[i];
			this.LHIGHGONHGQ[jbglefpolgp] = false;
			jbglefpolgp.MEGLEJHOGQK();
		}
		for (int j = 0; j < this.JQIPPDCFBIK.Count; j++)
		{
			JBGLEFPOLGP jbglefpolgp2 = this.JQIPPDCFBIK[j];
			this.LHIGHGONHGQ[jbglefpolgp2] = true;
			jbglefpolgp2.MNIFEBDOGKD();
		}
		this.KMFNKJIDLBP.Clear();
		this.JQIPPDCFBIK.Clear();
	}

	// Token: 0x060069B4 RID: 27060 RVA: 0x00344CAC File Offset: 0x00342EAC
	private void OnDisable()
	{
		foreach (KeyValuePair<CameraEvent, CommandBuffer> keyValuePair in this.HLLIPGKLHMC.Values)
		{
			this.HIJBBBEQPLF.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
			keyValuePair.Value.Dispose();
		}
		this.HLLIPGKLHMC.Clear();
		if (this.MQPNOMLJGKF != null)
		{
			this.JNIMNPFGDQG();
		}
		this.BLBLQMCNEDM.Clear();
		this.EOFOHIGLKOQ.Dispose();
		this.NFONHGOGFHL.Dispose();
		LGJGBKJCKPH.LPQIKIFQJMF();
	}

	// Token: 0x060069B5 RID: 27061 RVA: 0x00344D68 File Offset: 0x00342F68
	private void PELQDGFIJDH()
	{
		foreach (KeyValuePair<CameraEvent, CommandBuffer> keyValuePair in this.HLLIPGKLHMC.Values)
		{
			this.HIJBBBEQPLF.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
			keyValuePair.Value.Dispose();
		}
		this.HLLIPGKLHMC.Clear();
		if (this.MQPNOMLJGKF != null)
		{
			this.FOPQGBCKBPM();
		}
		this.BLBLQMCNEDM.Clear();
		this.EOFOHIGLKOQ.GHHIHHHCBNQ();
		this.NFONHGOGFHL.GPGCMDQLKQQ();
		LGJGBKJCKPH.LPQIKIFQJMF();
	}

	// Token: 0x060069B6 RID: 27062 RVA: 0x00344E24 File Offset: 0x00343024
	private void KJKQBFFOIHC(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			bool flag = false;
			bool ngqjliebfom = this.LMLMMOOLNFE.NGQJLIEBFOM;
			bool flag2 = !this.KKQOLNDNBOK.NGQJLIEBFOM || !this.LEOPCCDFEDD;
			bool flag3 = this.OLHEDDBCEME.NGQJLIEBFOM && this.LEOPCCDFEDD;
			Material material = this.EOFOHIGLKOQ.CCLFGNMOBMI("KEyeHistogram");
			material.shaderKeywords = null;
			RenderTexture renderTexture = PBHPQFLMQDB;
			if (flag2)
			{
				RenderTexture renderTexture2 = this.NFONHGOGFHL.DHLOEEOKKCL(renderTexture);
				this.KKQOLNDNBOK.ILCMMJMCPIE(renderTexture, renderTexture2);
				renderTexture = renderTexture2;
			}
			Texture texture = LGJGBKJCKPH.BHNJCHPOBIE;
			if (this.FFCHNPIPLQJ.NGQJLIEBFOM)
			{
				flag = true;
				texture = this.FFCHNPIPLQJ.CDGPNFDPKPQ(renderTexture, material);
			}
			material.SetTexture("grudge", texture);
			if (flag3)
			{
				flag = false;
				this.OLHEDDBCEME.OHOOHBNODFC(renderTexture, material, flag2, this.KKQOLNDNBOK.FHNJEEFNOOL(), this.KKQOLNDNBOK.FIFNHCKNDQE.DCPMJDLDNMM().taaSettings.motionBlending);
			}
			if (this.CNEPCMCNGGG.NGQJLIEBFOM)
			{
				flag = true;
				this.CNEPCMCNGGG.FLHPMJGDDFD(renderTexture, material, texture);
			}
			flag = (flag | this.QGCELBLJPHK<ChromaticAberrationModel>(this.KLKFKEDBNHP, material) | this.QGCELBLJPHK<ColorGradingModel>(this.DOCNMEJBPOJ, material) | this.QGCELBLJPHK<VignetteModel>(this.CPBJPCLLDGH, material) | this.QGCELBLJPHK<UserLutModel>(this.OINFDKKBFEE, material));
			Material material2 = (!ngqjliebfom) ? null : this.EOFOHIGLKOQ.GHPBFKKGJDO("5");
			if (ngqjliebfom)
			{
				material2.shaderKeywords = null;
				this.QGCELBLJPHK<GrainModel>(this.MDLQNNDBIMB, material2);
				this.QGCELBLJPHK<DitheringModel>(this.KPDQEIOILLE, material2);
				if (flag)
				{
					RenderTexture renderTexture3 = this.NFONHGOGFHL.OPMDBFNDEBD(renderTexture);
					Graphics.Blit(renderTexture, renderTexture3, material, 1);
					renderTexture = renderTexture3;
				}
				this.LMLMMOOLNFE.CHQPHOGBBQI(renderTexture, OBEPQQEKFLC);
			}
			else if (flag = (flag | this.QGCELBLJPHK<GrainModel>(this.MDLQNNDBIMB, material) | this.QGCELBLJPHK<DitheringModel>(this.KPDQEIOILLE, material)))
			{
				if (!LGJGBKJCKPH.HDMIHMIGIKJ)
				{
					material.EnableKeyword("normal");
				}
				Graphics.Blit(renderTexture, OBEPQQEKFLC, material, 1);
			}
			if (!flag && !ngqjliebfom)
			{
				Graphics.Blit(renderTexture, OBEPQQEKFLC);
			}
			this.NFONHGOGFHL.ECKEBCJPIHE();
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x060069B7 RID: 27063 RVA: 0x0034508C File Offset: 0x0034328C
	private void JQLCFDOKMFF()
	{
		foreach (KeyValuePair<JBGLEFPOLGP, bool> keyValuePair in this.LHIGHGONHGQ)
		{
			JBGLEFPOLGP key = keyValuePair.Key;
			bool enabled;
			if ((enabled = key.CEKEFONEMIK().enabled) != keyValuePair.Value)
			{
				if (enabled)
				{
					this.JQIPPDCFBIK.Add(key);
				}
				else
				{
					this.KMFNKJIDLBP.Add(key);
				}
			}
		}
		for (int i = 1; i < this.KMFNKJIDLBP.Count; i += 0)
		{
			JBGLEFPOLGP jbglefpolgp = this.KMFNKJIDLBP[i];
			this.LHIGHGONHGQ[jbglefpolgp] = true;
			jbglefpolgp.MEGLEJHOGQK();
		}
		for (int j = 1; j < this.JQIPPDCFBIK.Count; j += 0)
		{
			JBGLEFPOLGP jbglefpolgp2 = this.JQIPPDCFBIK[j];
			this.LHIGHGONHGQ[jbglefpolgp2] = false;
			jbglefpolgp2.MNIFEBDOGKD();
		}
		this.KMFNKJIDLBP.Clear();
		this.JQIPPDCFBIK.Clear();
	}

	// Token: 0x060069B8 RID: 27064 RVA: 0x003451A8 File Offset: 0x003433A8
	private void MKNEDKFCDFC()
	{
		if (Event.current.type != EventType.ScrollWheel)
		{
			return;
		}
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			if (this.FFCHNPIPLQJ.NGQJLIEBFOM && this.MQPNOMLJGKF.debugViews.EKLOGKFNJHB(BuiltinDebugViewsModel.HMFGKHHHIPL.AmbientOcclusion))
			{
				this.FFCHNPIPLQJ.OBCBHELFKHK();
			}
			else if (this.DOCNMEJBPOJ.NGQJLIEBFOM && this.MQPNOMLJGKF.debugViews.HIFCCQDDLJH(BuiltinDebugViewsModel.HMFGKHHHIPL.AmbientOcclusion))
			{
				this.DOCNMEJBPOJ.JOODKIHMODG();
			}
			else if (this.OINFDKKBFEE.NGQJLIEBFOM && this.MQPNOMLJGKF.debugViews.EKLOGKFNJHB((BuiltinDebugViewsModel.HMFGKHHHIPL)(-85)))
			{
				this.OINFDKKBFEE.LPFDNCGKFCD();
			}
			return;
		}
	}

	// Token: 0x060069B9 RID: 27065 RVA: 0x0034526C File Offset: 0x0034346C
	private void DBJLGLPQHLH()
	{
		foreach (KeyValuePair<CameraEvent, CommandBuffer> keyValuePair in this.HLLIPGKLHMC.Values)
		{
			this.HIJBBBEQPLF.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
			keyValuePair.Value.Dispose();
		}
		this.HLLIPGKLHMC.Clear();
		if (this.MQPNOMLJGKF != null)
		{
			this.JNIMNPFGDQG();
		}
		this.BLBLQMCNEDM.Clear();
		this.EOFOHIGLKOQ.IGCHGHCJHHC();
		this.NFONHGOGFHL.Dispose();
		LGJGBKJCKPH.LPQIKIFQJMF();
	}

	// Token: 0x060069BA RID: 27066 RVA: 0x00345328 File Offset: 0x00343528
	private void BGPFMBOBCBH()
	{
		foreach (JBGLEFPOLGP jbglefpolgp in this.BLBLQMCNEDM)
		{
			PostProcessingModel postProcessingModel = jbglefpolgp.CEKEFONEMIK();
			if (postProcessingModel != null && postProcessingModel.enabled)
			{
				jbglefpolgp.MEGLEJHOGQK();
			}
		}
	}

	// Token: 0x060069BB RID: 27067 RVA: 0x00345390 File Offset: 0x00343590
	private void OnRenderImage(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			bool flag = false;
			bool ngqjliebfom = this.LMLMMOOLNFE.NGQJLIEBFOM;
			bool flag2 = this.KKQOLNDNBOK.NGQJLIEBFOM && !this.LEOPCCDFEDD;
			bool flag3 = this.OLHEDDBCEME.NGQJLIEBFOM && !this.LEOPCCDFEDD;
			Material material = this.EOFOHIGLKOQ.INJNQNMOKKD("Hidden/Post FX/Uber Shader");
			material.shaderKeywords = null;
			RenderTexture renderTexture = PBHPQFLMQDB;
			if (flag2)
			{
				RenderTexture renderTexture2 = this.NFONHGOGFHL.INJNQNMOKKD(renderTexture);
				this.KKQOLNDNBOK.ILCMMJMCPIE(renderTexture, renderTexture2);
				renderTexture = renderTexture2;
			}
			Texture texture = LGJGBKJCKPH.BHNJCHPOBIE;
			if (this.FFCHNPIPLQJ.NGQJLIEBFOM)
			{
				flag = true;
				texture = this.FFCHNPIPLQJ.DFLOLMMCGID(renderTexture, material);
			}
			material.SetTexture("_AutoExposure", texture);
			if (flag3)
			{
				flag = true;
				this.OLHEDDBCEME.DFLOLMMCGID(renderTexture, material, flag2, this.KKQOLNDNBOK.CGLOQGHDLEF, this.KKQOLNDNBOK.FIFNHCKNDQE.settings.taaSettings.motionBlending);
			}
			if (this.CNEPCMCNGGG.NGQJLIEBFOM)
			{
				flag = true;
				this.CNEPCMCNGGG.DFLOLMMCGID(renderTexture, material, texture);
			}
			flag = (flag | this.QGCELBLJPHK<ChromaticAberrationModel>(this.KLKFKEDBNHP, material) | this.QGCELBLJPHK<ColorGradingModel>(this.DOCNMEJBPOJ, material) | this.QGCELBLJPHK<VignetteModel>(this.CPBJPCLLDGH, material) | this.QGCELBLJPHK<UserLutModel>(this.OINFDKKBFEE, material));
			Material material2 = (!ngqjliebfom) ? null : this.EOFOHIGLKOQ.INJNQNMOKKD("Hidden/Post FX/FXAA");
			if (ngqjliebfom)
			{
				material2.shaderKeywords = null;
				this.QGCELBLJPHK<GrainModel>(this.MDLQNNDBIMB, material2);
				this.QGCELBLJPHK<DitheringModel>(this.KPDQEIOILLE, material2);
				if (flag)
				{
					RenderTexture renderTexture3 = this.NFONHGOGFHL.INJNQNMOKKD(renderTexture);
					Graphics.Blit(renderTexture, renderTexture3, material, 0);
					renderTexture = renderTexture3;
				}
				this.LMLMMOOLNFE.ILCMMJMCPIE(renderTexture, OBEPQQEKFLC);
			}
			else if (flag = (flag | this.QGCELBLJPHK<GrainModel>(this.MDLQNNDBIMB, material) | this.QGCELBLJPHK<DitheringModel>(this.KPDQEIOILLE, material)))
			{
				if (!LGJGBKJCKPH.HDMIHMIGIKJ)
				{
					material.EnableKeyword("UNITY_COLORSPACE_GAMMA");
				}
				Graphics.Blit(renderTexture, OBEPQQEKFLC, material, 0);
			}
			if (!flag && !ngqjliebfom)
			{
				Graphics.Blit(renderTexture, OBEPQQEKFLC);
			}
			this.NFONHGOGFHL.ECKEBCJPIHE();
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x060069BC RID: 27068 RVA: 0x003455F8 File Offset: 0x003437F8
	private void NGNFOLIIOCI()
	{
		foreach (KeyValuePair<CameraEvent, CommandBuffer> keyValuePair in this.HLLIPGKLHMC.Values)
		{
			this.HIJBBBEQPLF.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
			keyValuePair.Value.Dispose();
		}
		this.HLLIPGKLHMC.Clear();
		if (this.MQPNOMLJGKF != null)
		{
			this.JNIMNPFGDQG();
		}
		this.BLBLQMCNEDM.Clear();
		this.EOFOHIGLKOQ.FHICJOCHQFQ();
		this.NFONHGOGFHL.GPGCMDQLKQQ();
		LGJGBKJCKPH.LPQIKIFQJMF();
	}

	// Token: 0x060069BD RID: 27069 RVA: 0x003456B4 File Offset: 0x003438B4
	private void OnPreRender()
	{
		if (this.MQPNOMLJGKF == null)
		{
			return;
		}
		this.NBEMJHQNBCP<BuiltinDebugViewsModel>(this.HDOQLDEJOMG);
		this.NBEMJHQNBCP<AmbientOcclusionModel>(this.CMMKNCCBMPJ);
		this.NBEMJHQNBCP<ScreenSpaceReflectionModel>(this.DGQNIOMQHHO);
		this.NBEMJHQNBCP<FogModel>(this.GPIFGGIHBPP);
		if (!this.LEOPCCDFEDD)
		{
			this.NBEMJHQNBCP<MotionBlurModel>(this.BQBEDGDPLCN);
		}
	}

	// Token: 0x060069BE RID: 27070 RVA: 0x00027D8F File Offset: 0x00025F8F
	public void LCLMHKNKLCG()
	{
		this.KKQOLNDNBOK.LFIDMKPQKKM();
		this.BQBEDGDPLCN.GIJLJEIHDBC();
		this.FFCHNPIPLQJ.KPECJMCFBJN();
	}

	// Token: 0x060069BF RID: 27071 RVA: 0x00345714 File Offset: 0x00343914
	private CommandBuffer MJBBKCQDGEI<T>(CameraEvent EKMDMIDCEIM, string IHIHHCCEDHQ) where T : PostProcessingModel
	{
		CommandBuffer value = new CommandBuffer
		{
			name = IHIHHCCEDHQ
		};
		KeyValuePair<CameraEvent, CommandBuffer> value2 = new KeyValuePair<CameraEvent, CommandBuffer>(EKMDMIDCEIM, value);
		this.HLLIPGKLHMC.Add(typeof(T), value2);
		this.HIJBBBEQPLF.AddCommandBuffer(EKMDMIDCEIM, value2.Value);
		return value2.Value;
	}

	// Token: 0x060069C0 RID: 27072 RVA: 0x0034576C File Offset: 0x0034396C
	private void IIKNHGOMQEG()
	{
		this.HLLIPGKLHMC = new Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>>();
		this.EOFOHIGLKOQ = new HCKCDDQBDQD();
		this.NFONHGOGFHL = new PIJIQKMKDPO();
		this.FCPEIDMLEJC = new NNLOOFHPMNG();
		this.BLBLQMCNEDM = new List<JBGLEFPOLGP>();
		this.HDOQLDEJOMG = this.MJBLILJEBKC<MCBPLMFFGJC>(new MCBPLMFFGJC());
		this.CMMKNCCBMPJ = this.MJBLILJEBKC<FCJPPQICFGF>(new FCJPPQICFGF());
		this.DGQNIOMQHHO = this.MJBLILJEBKC<NHGDDFNJIPM>(new NHGDDFNJIPM());
		this.GPIFGGIHBPP = this.MJBLILJEBKC<KEIGFGDMQBF>(new KEIGFGDMQBF());
		this.BQBEDGDPLCN = this.MJBLILJEBKC<JKKJMOGLOOL>(new JKKJMOGLOOL());
		this.KKQOLNDNBOK = this.MJBLILJEBKC<FOFDHFBCNKC>(new FOFDHFBCNKC());
		this.FFCHNPIPLQJ = this.MJBLILJEBKC<KDMBLOFFMFG>(new KDMBLOFFMFG());
		this.OLHEDDBCEME = this.MJBLILJEBKC<LFEMGHQGCKK>(new LFEMGHQGCKK());
		this.CNEPCMCNGGG = this.MJBLILJEBKC<BJMBMMBMQHQ>(new BJMBMMBMQHQ());
		this.KLKFKEDBNHP = this.MJBLILJEBKC<QHPGHOFCBQD>(new QHPGHOFCBQD());
		this.DOCNMEJBPOJ = this.MJBLILJEBKC<KBCEDGOCEJQ>(new KBCEDGOCEJQ());
		this.OINFDKKBFEE = this.MJBLILJEBKC<JNLLDFGOFKP>(new JNLLDFGOFKP());
		this.MDLQNNDBIMB = this.MJBLILJEBKC<FFMEDEIIJOC>(new FFMEDEIIJOC());
		this.CPBJPCLLDGH = this.MJBLILJEBKC<NIJBPFMLQMP>(new NIJBPFMLQMP());
		this.KPDQEIOILLE = this.MJBLILJEBKC<LQHLOGDKHCQ>(new LQHLOGDKHCQ());
		this.LMLMMOOLNFE = this.MJBLILJEBKC<LJMJFHFGPJK>(new LJMJFHFGPJK());
		this.LHIGHGONHGQ = new Dictionary<JBGLEFPOLGP, bool>();
		foreach (JBGLEFPOLGP key in this.BLBLQMCNEDM)
		{
			this.LHIGHGONHGQ.Add(key, true);
		}
		base.useGUILayout = true;
	}

	// Token: 0x060069C1 RID: 27073 RVA: 0x0034576C File Offset: 0x0034396C
	private void QGIIBINIPIN()
	{
		this.HLLIPGKLHMC = new Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>>();
		this.EOFOHIGLKOQ = new HCKCDDQBDQD();
		this.NFONHGOGFHL = new PIJIQKMKDPO();
		this.FCPEIDMLEJC = new NNLOOFHPMNG();
		this.BLBLQMCNEDM = new List<JBGLEFPOLGP>();
		this.HDOQLDEJOMG = this.MJBLILJEBKC<MCBPLMFFGJC>(new MCBPLMFFGJC());
		this.CMMKNCCBMPJ = this.MJBLILJEBKC<FCJPPQICFGF>(new FCJPPQICFGF());
		this.DGQNIOMQHHO = this.MJBLILJEBKC<NHGDDFNJIPM>(new NHGDDFNJIPM());
		this.GPIFGGIHBPP = this.MJBLILJEBKC<KEIGFGDMQBF>(new KEIGFGDMQBF());
		this.BQBEDGDPLCN = this.MJBLILJEBKC<JKKJMOGLOOL>(new JKKJMOGLOOL());
		this.KKQOLNDNBOK = this.MJBLILJEBKC<FOFDHFBCNKC>(new FOFDHFBCNKC());
		this.FFCHNPIPLQJ = this.MJBLILJEBKC<KDMBLOFFMFG>(new KDMBLOFFMFG());
		this.OLHEDDBCEME = this.MJBLILJEBKC<LFEMGHQGCKK>(new LFEMGHQGCKK());
		this.CNEPCMCNGGG = this.MJBLILJEBKC<BJMBMMBMQHQ>(new BJMBMMBMQHQ());
		this.KLKFKEDBNHP = this.MJBLILJEBKC<QHPGHOFCBQD>(new QHPGHOFCBQD());
		this.DOCNMEJBPOJ = this.MJBLILJEBKC<KBCEDGOCEJQ>(new KBCEDGOCEJQ());
		this.OINFDKKBFEE = this.MJBLILJEBKC<JNLLDFGOFKP>(new JNLLDFGOFKP());
		this.MDLQNNDBIMB = this.MJBLILJEBKC<FFMEDEIIJOC>(new FFMEDEIIJOC());
		this.CPBJPCLLDGH = this.MJBLILJEBKC<NIJBPFMLQMP>(new NIJBPFMLQMP());
		this.KPDQEIOILLE = this.MJBLILJEBKC<LQHLOGDKHCQ>(new LQHLOGDKHCQ());
		this.LMLMMOOLNFE = this.MJBLILJEBKC<LJMJFHFGPJK>(new LJMJFHFGPJK());
		this.LHIGHGONHGQ = new Dictionary<JBGLEFPOLGP, bool>();
		foreach (JBGLEFPOLGP key in this.BLBLQMCNEDM)
		{
			this.LHIGHGONHGQ.Add(key, true);
		}
		base.useGUILayout = true;
	}

	// Token: 0x060069C2 RID: 27074 RVA: 0x00345920 File Offset: 0x00343B20
	private void NNBNJQECJBE()
	{
		foreach (KeyValuePair<CameraEvent, CommandBuffer> keyValuePair in this.HLLIPGKLHMC.Values)
		{
			this.HIJBBBEQPLF.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
			keyValuePair.Value.Dispose();
		}
		this.HLLIPGKLHMC.Clear();
		if (this.MQPNOMLJGKF != null)
		{
			this.JNIMNPFGDQG();
		}
		this.BLBLQMCNEDM.Clear();
		this.EOFOHIGLKOQ.MBPOGOHPCHP();
		this.NFONHGOGFHL.ECGDGNFJPBO();
		LGJGBKJCKPH.LPQIKIFQJMF();
	}

	// Token: 0x060069C3 RID: 27075 RVA: 0x003459DC File Offset: 0x00343BDC
	private void QDDMQJBDBGL()
	{
		foreach (KeyValuePair<JBGLEFPOLGP, bool> keyValuePair in this.LHIGHGONHGQ)
		{
			JBGLEFPOLGP key = keyValuePair.Key;
			bool enabled;
			if ((enabled = key.CEKEFONEMIK().enabled) != keyValuePair.Value)
			{
				if (enabled)
				{
					this.JQIPPDCFBIK.Add(key);
				}
				else
				{
					this.KMFNKJIDLBP.Add(key);
				}
			}
		}
		for (int i = 0; i < this.KMFNKJIDLBP.Count; i++)
		{
			JBGLEFPOLGP jbglefpolgp = this.KMFNKJIDLBP[i];
			this.LHIGHGONHGQ[jbglefpolgp] = false;
			jbglefpolgp.MEGLEJHOGQK();
		}
		for (int j = 0; j < this.JQIPPDCFBIK.Count; j++)
		{
			JBGLEFPOLGP jbglefpolgp2 = this.JQIPPDCFBIK[j];
			this.LHIGHGONHGQ[jbglefpolgp2] = true;
			jbglefpolgp2.MNIFEBDOGKD();
		}
		this.KMFNKJIDLBP.Clear();
		this.JQIPPDCFBIK.Clear();
	}

	// Token: 0x060069C4 RID: 27076 RVA: 0x00345AF8 File Offset: 0x00343CF8
	private void OnEnable()
	{
		this.HLLIPGKLHMC = new Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>>();
		this.EOFOHIGLKOQ = new HCKCDDQBDQD();
		this.NFONHGOGFHL = new PIJIQKMKDPO();
		this.FCPEIDMLEJC = new NNLOOFHPMNG();
		this.BLBLQMCNEDM = new List<JBGLEFPOLGP>();
		this.HDOQLDEJOMG = this.MJBLILJEBKC<MCBPLMFFGJC>(new MCBPLMFFGJC());
		this.CMMKNCCBMPJ = this.MJBLILJEBKC<FCJPPQICFGF>(new FCJPPQICFGF());
		this.DGQNIOMQHHO = this.MJBLILJEBKC<NHGDDFNJIPM>(new NHGDDFNJIPM());
		this.GPIFGGIHBPP = this.MJBLILJEBKC<KEIGFGDMQBF>(new KEIGFGDMQBF());
		this.BQBEDGDPLCN = this.MJBLILJEBKC<JKKJMOGLOOL>(new JKKJMOGLOOL());
		this.KKQOLNDNBOK = this.MJBLILJEBKC<FOFDHFBCNKC>(new FOFDHFBCNKC());
		this.FFCHNPIPLQJ = this.MJBLILJEBKC<KDMBLOFFMFG>(new KDMBLOFFMFG());
		this.OLHEDDBCEME = this.MJBLILJEBKC<LFEMGHQGCKK>(new LFEMGHQGCKK());
		this.CNEPCMCNGGG = this.MJBLILJEBKC<BJMBMMBMQHQ>(new BJMBMMBMQHQ());
		this.KLKFKEDBNHP = this.MJBLILJEBKC<QHPGHOFCBQD>(new QHPGHOFCBQD());
		this.DOCNMEJBPOJ = this.MJBLILJEBKC<KBCEDGOCEJQ>(new KBCEDGOCEJQ());
		this.OINFDKKBFEE = this.MJBLILJEBKC<JNLLDFGOFKP>(new JNLLDFGOFKP());
		this.MDLQNNDBIMB = this.MJBLILJEBKC<FFMEDEIIJOC>(new FFMEDEIIJOC());
		this.CPBJPCLLDGH = this.MJBLILJEBKC<NIJBPFMLQMP>(new NIJBPFMLQMP());
		this.KPDQEIOILLE = this.MJBLILJEBKC<LQHLOGDKHCQ>(new LQHLOGDKHCQ());
		this.LMLMMOOLNFE = this.MJBLILJEBKC<LJMJFHFGPJK>(new LJMJFHFGPJK());
		this.LHIGHGONHGQ = new Dictionary<JBGLEFPOLGP, bool>();
		foreach (JBGLEFPOLGP key in this.BLBLQMCNEDM)
		{
			this.LHIGHGONHGQ.Add(key, false);
		}
		base.useGUILayout = false;
	}

	// Token: 0x060069C5 RID: 27077 RVA: 0x00345CAC File Offset: 0x00343EAC
	private void ELQNGOGBIGL(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			bool flag = false;
			bool ngqjliebfom = this.LMLMMOOLNFE.NGQJLIEBFOM;
			bool flag2 = this.KKQOLNDNBOK.NGQJLIEBFOM && !this.LEOPCCDFEDD;
			bool flag3 = !this.OLHEDDBCEME.NGQJLIEBFOM || !this.LEOPCCDFEDD;
			Material material = this.EOFOHIGLKOQ.JOLPMHHECLG("[-]");
			material.shaderKeywords = null;
			RenderTexture renderTexture = PBHPQFLMQDB;
			if (flag2)
			{
				RenderTexture renderTexture2 = this.NFONHGOGFHL.OPMDBFNDEBD(renderTexture);
				this.KKQOLNDNBOK.KOGLCCNQJIC(renderTexture, renderTexture2);
				renderTexture = renderTexture2;
			}
			Texture texture = LGJGBKJCKPH.BHNJCHPOBIE;
			if (this.FFCHNPIPLQJ.NGQJLIEBFOM)
			{
				flag = true;
				texture = this.FFCHNPIPLQJ.KJGHGLQFCEG(renderTexture, material);
			}
			material.SetTexture("Map", texture);
			if (flag3)
			{
				flag = true;
				this.OLHEDDBCEME.OHOOHBNODFC(renderTexture, material, flag2, this.KKQOLNDNBOK.FHNJEEFNOOL(), this.KKQOLNDNBOK.FIFNHCKNDQE.DNDPKMIFFDJ().taaSettings.motionBlending);
			}
			if (this.CNEPCMCNGGG.NGQJLIEBFOM)
			{
				flag = false;
				this.CNEPCMCNGGG.CDGPNFDPKPQ(renderTexture, material, texture);
			}
			flag = (flag | this.QGCELBLJPHK<ChromaticAberrationModel>(this.KLKFKEDBNHP, material) | this.QGCELBLJPHK<ColorGradingModel>(this.DOCNMEJBPOJ, material) | this.QGCELBLJPHK<VignetteModel>(this.CPBJPCLLDGH, material) | this.QGCELBLJPHK<UserLutModel>(this.OINFDKKBFEE, material));
			Material material2 = (!ngqjliebfom) ? null : this.EOFOHIGLKOQ.FJIJQOQKHGK("\r\nSPD");
			if (ngqjliebfom)
			{
				material2.shaderKeywords = null;
				this.QGCELBLJPHK<GrainModel>(this.MDLQNNDBIMB, material2);
				this.QGCELBLJPHK<DitheringModel>(this.KPDQEIOILLE, material2);
				if (flag)
				{
					RenderTexture renderTexture3 = this.NFONHGOGFHL.OPMDBFNDEBD(renderTexture);
					Graphics.Blit(renderTexture, renderTexture3, material, 1);
					renderTexture = renderTexture3;
				}
				this.LMLMMOOLNFE.QNEQEMBHDDB(renderTexture, OBEPQQEKFLC);
			}
			else if (flag = (flag | this.QGCELBLJPHK<GrainModel>(this.MDLQNNDBIMB, material) | this.QGCELBLJPHK<DitheringModel>(this.KPDQEIOILLE, material)))
			{
				if (!LGJGBKJCKPH.HDMIHMIGIKJ)
				{
					material.EnableKeyword(" breaks the mold!\r\n");
				}
				Graphics.Blit(renderTexture, OBEPQQEKFLC, material, 0);
			}
			if (!flag && !ngqjliebfom)
			{
				Graphics.Blit(renderTexture, OBEPQQEKFLC);
			}
			this.NFONHGOGFHL.FCBKNMEDHQE();
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x060069C6 RID: 27078 RVA: 0x00345F14 File Offset: 0x00344114
	private void FLKHQHIGFOL()
	{
		this.HLLIPGKLHMC = new Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>>();
		this.EOFOHIGLKOQ = new HCKCDDQBDQD();
		this.NFONHGOGFHL = new PIJIQKMKDPO();
		this.FCPEIDMLEJC = new NNLOOFHPMNG();
		this.BLBLQMCNEDM = new List<JBGLEFPOLGP>();
		this.HDOQLDEJOMG = this.MJBLILJEBKC<MCBPLMFFGJC>(new MCBPLMFFGJC());
		this.CMMKNCCBMPJ = this.MJBLILJEBKC<FCJPPQICFGF>(new FCJPPQICFGF());
		this.DGQNIOMQHHO = this.MJBLILJEBKC<NHGDDFNJIPM>(new NHGDDFNJIPM());
		this.GPIFGGIHBPP = this.MJBLILJEBKC<KEIGFGDMQBF>(new KEIGFGDMQBF());
		this.BQBEDGDPLCN = this.MJBLILJEBKC<JKKJMOGLOOL>(new JKKJMOGLOOL());
		this.KKQOLNDNBOK = this.MJBLILJEBKC<FOFDHFBCNKC>(new FOFDHFBCNKC());
		this.FFCHNPIPLQJ = this.MJBLILJEBKC<KDMBLOFFMFG>(new KDMBLOFFMFG());
		this.OLHEDDBCEME = this.MJBLILJEBKC<LFEMGHQGCKK>(new LFEMGHQGCKK());
		this.CNEPCMCNGGG = this.MJBLILJEBKC<BJMBMMBMQHQ>(new BJMBMMBMQHQ());
		this.KLKFKEDBNHP = this.MJBLILJEBKC<QHPGHOFCBQD>(new QHPGHOFCBQD());
		this.DOCNMEJBPOJ = this.MJBLILJEBKC<KBCEDGOCEJQ>(new KBCEDGOCEJQ());
		this.OINFDKKBFEE = this.MJBLILJEBKC<JNLLDFGOFKP>(new JNLLDFGOFKP());
		this.MDLQNNDBIMB = this.MJBLILJEBKC<FFMEDEIIJOC>(new FFMEDEIIJOC());
		this.CPBJPCLLDGH = this.MJBLILJEBKC<NIJBPFMLQMP>(new NIJBPFMLQMP());
		this.KPDQEIOILLE = this.MJBLILJEBKC<LQHLOGDKHCQ>(new LQHLOGDKHCQ());
		this.LMLMMOOLNFE = this.MJBLILJEBKC<LJMJFHFGPJK>(new LJMJFHFGPJK());
		this.LHIGHGONHGQ = new Dictionary<JBGLEFPOLGP, bool>();
		foreach (JBGLEFPOLGP key in this.BLBLQMCNEDM)
		{
			this.LHIGHGONHGQ.Add(key, false);
		}
		base.useGUILayout = true;
	}

	// Token: 0x060069C7 RID: 27079 RVA: 0x003460C8 File Offset: 0x003442C8
	private void OnPreCull()
	{
		this.HIJBBBEQPLF = base.GetComponent<Camera>();
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			NNLOOFHPMNG nnloofhpmng = this.FCPEIDMLEJC.BJJGDIOLJMI();
			nnloofhpmng.MQPNOMLJGKF = this.MQPNOMLJGKF;
			nnloofhpmng.QKMKFPCOPEF = this.NFONHGOGFHL;
			nnloofhpmng.GOQBDJHFOPK = this.EOFOHIGLKOQ;
			nnloofhpmng.LNCKNGKGHLN = this.HIJBBBEQPLF;
			this.HDOQLDEJOMG.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.debugViews);
			this.CMMKNCCBMPJ.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.ambientOcclusion);
			this.DGQNIOMQHHO.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.screenSpaceReflection);
			this.GPIFGGIHBPP.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.fog);
			this.BQBEDGDPLCN.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.motionBlur);
			this.KKQOLNDNBOK.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.antialiasing);
			this.FFCHNPIPLQJ.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.eyeAdaptation);
			this.OLHEDDBCEME.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.depthOfField);
			this.CNEPCMCNGGG.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.bloom);
			this.KLKFKEDBNHP.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.chromaticAberration);
			this.DOCNMEJBPOJ.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.colorGrading);
			this.OINFDKKBFEE.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.userLut);
			this.MDLQNNDBIMB.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.grain);
			this.CPBJPCLLDGH.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.vignette);
			this.KPDQEIOILLE.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.dithering);
			this.LMLMMOOLNFE.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.antialiasing);
			if (this.FCJJPMPILMN != this.MQPNOMLJGKF)
			{
				this.JNIMNPFGDQG();
				this.FCJJPMPILMN = this.MQPNOMLJGKF;
			}
			this.QDDMQJBDBGL();
			DepthTextureMode depthTextureMode = nnloofhpmng.LNCKNGKGHLN.depthTextureMode;
			foreach (JBGLEFPOLGP jbglefpolgp in this.BLBLQMCNEDM)
			{
				if (jbglefpolgp.NGQJLIEBFOM)
				{
					depthTextureMode |= jbglefpolgp.FDQNPDGFNHH();
				}
			}
			nnloofhpmng.LNCKNGKGHLN.depthTextureMode = depthTextureMode;
			if (!this.LEOPCCDFEDD && this.KKQOLNDNBOK.NGQJLIEBFOM && !this.MQPNOMLJGKF.debugViews.willInterrupt)
			{
				this.KKQOLNDNBOK.GMPBDDDCIHK(this.NQNMOEDDOQN);
			}
			return;
		}
	}

	// Token: 0x060069C8 RID: 27080 RVA: 0x0034637C File Offset: 0x0034457C
	private void NECEMHFDLGI(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			bool flag = true;
			bool ngqjliebfom = this.LMLMMOOLNFE.NGQJLIEBFOM;
			bool flag2 = !this.KKQOLNDNBOK.NGQJLIEBFOM || !this.LEOPCCDFEDD;
			bool flag3 = this.OLHEDDBCEME.NGQJLIEBFOM && !this.LEOPCCDFEDD;
			Material material = this.EOFOHIGLKOQ.GONNQQIJNLJ("3");
			material.shaderKeywords = null;
			RenderTexture renderTexture = PBHPQFLMQDB;
			if (flag2)
			{
				RenderTexture renderTexture2 = this.NFONHGOGFHL.ODOJHJGHDNO(renderTexture);
				this.KKQOLNDNBOK.KOGLCCNQJIC(renderTexture, renderTexture2);
				renderTexture = renderTexture2;
			}
			Texture texture = LGJGBKJCKPH.BHNJCHPOBIE;
			if (this.FFCHNPIPLQJ.NGQJLIEBFOM)
			{
				flag = true;
				texture = this.FFCHNPIPLQJ.KJGHGLQFCEG(renderTexture, material);
			}
			material.SetTexture("fairyaura", texture);
			if (flag3)
			{
				flag = true;
				this.OLHEDDBCEME.OHOOHBNODFC(renderTexture, material, flag2, this.KKQOLNDNBOK.FHNJEEFNOOL(), this.KKQOLNDNBOK.FIFNHCKNDQE.DCPMJDLDNMM().taaSettings.motionBlending);
			}
			if (this.CNEPCMCNGGG.NGQJLIEBFOM)
			{
				flag = false;
				this.CNEPCMCNGGG.BFIQNHPQMKM(renderTexture, material, texture);
			}
			flag = (flag | this.QGCELBLJPHK<ChromaticAberrationModel>(this.KLKFKEDBNHP, material) | this.QGCELBLJPHK<ColorGradingModel>(this.DOCNMEJBPOJ, material) | this.QGCELBLJPHK<VignetteModel>(this.CPBJPCLLDGH, material) | this.QGCELBLJPHK<UserLutModel>(this.OINFDKKBFEE, material));
			Material material2 = (!ngqjliebfom) ? null : this.EOFOHIGLKOQ.QDMHMMGFIOJ("Offline");
			if (ngqjliebfom)
			{
				material2.shaderKeywords = null;
				this.QGCELBLJPHK<GrainModel>(this.MDLQNNDBIMB, material2);
				this.QGCELBLJPHK<DitheringModel>(this.KPDQEIOILLE, material2);
				if (flag)
				{
					RenderTexture renderTexture3 = this.NFONHGOGFHL.INJNQNMOKKD(renderTexture);
					Graphics.Blit(renderTexture, renderTexture3, material, 0);
					renderTexture = renderTexture3;
				}
				this.LMLMMOOLNFE.QNEQEMBHDDB(renderTexture, OBEPQQEKFLC);
			}
			else if (flag = (flag | this.QGCELBLJPHK<GrainModel>(this.MDLQNNDBIMB, material) | this.QGCELBLJPHK<DitheringModel>(this.KPDQEIOILLE, material)))
			{
				if (!LGJGBKJCKPH.HDMIHMIGIKJ)
				{
					material.EnableKeyword("_1");
				}
				Graphics.Blit(renderTexture, OBEPQQEKFLC, material, 1);
			}
			if (!flag && !ngqjliebfom)
			{
				Graphics.Blit(renderTexture, OBEPQQEKFLC);
			}
			this.NFONHGOGFHL.PIMHDLDBNGP();
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x060069C9 RID: 27081 RVA: 0x003465E4 File Offset: 0x003447E4
	private void MKDMQBQMKGB()
	{
		this.HIJBBBEQPLF = base.GetComponent<Camera>();
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			NNLOOFHPMNG nnloofhpmng = this.FCPEIDMLEJC.BIFDELJCEQP();
			nnloofhpmng.MQPNOMLJGKF = this.MQPNOMLJGKF;
			nnloofhpmng.QKMKFPCOPEF = this.NFONHGOGFHL;
			nnloofhpmng.GOQBDJHFOPK = this.EOFOHIGLKOQ;
			nnloofhpmng.LNCKNGKGHLN = this.HIJBBBEQPLF;
			this.HDOQLDEJOMG.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.debugViews);
			this.CMMKNCCBMPJ.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.ambientOcclusion);
			this.DGQNIOMQHHO.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.screenSpaceReflection);
			this.GPIFGGIHBPP.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.fog);
			this.BQBEDGDPLCN.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.motionBlur);
			this.KKQOLNDNBOK.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.antialiasing);
			this.FFCHNPIPLQJ.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.eyeAdaptation);
			this.OLHEDDBCEME.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.depthOfField);
			this.CNEPCMCNGGG.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.bloom);
			this.KLKFKEDBNHP.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.chromaticAberration);
			this.DOCNMEJBPOJ.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.colorGrading);
			this.OINFDKKBFEE.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.userLut);
			this.MDLQNNDBIMB.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.grain);
			this.CPBJPCLLDGH.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.vignette);
			this.KPDQEIOILLE.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.dithering);
			this.LMLMMOOLNFE.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.antialiasing);
			if (this.FCJJPMPILMN != this.MQPNOMLJGKF)
			{
				this.BGPFMBOBCBH();
				this.FCJJPMPILMN = this.MQPNOMLJGKF;
			}
			this.QDDMQJBDBGL();
			DepthTextureMode depthTextureMode = nnloofhpmng.LNCKNGKGHLN.depthTextureMode;
			foreach (JBGLEFPOLGP jbglefpolgp in this.BLBLQMCNEDM)
			{
				if (jbglefpolgp.NGQJLIEBFOM)
				{
					depthTextureMode |= jbglefpolgp.FDQNPDGFNHH();
				}
			}
			nnloofhpmng.LNCKNGKGHLN.depthTextureMode = depthTextureMode;
			if (!this.LEOPCCDFEDD && this.KKQOLNDNBOK.NGQJLIEBFOM && !this.MQPNOMLJGKF.debugViews.QHKKOJMCFKQ())
			{
				this.KKQOLNDNBOK.PLEJDCFBKLC(this.NQNMOEDDOQN);
			}
			return;
		}
	}

	// Token: 0x060069CA RID: 27082 RVA: 0x00346898 File Offset: 0x00344A98
	private void ENEEJOGCLEB()
	{
		foreach (KeyValuePair<CameraEvent, CommandBuffer> keyValuePair in this.HLLIPGKLHMC.Values)
		{
			this.HIJBBBEQPLF.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
			keyValuePair.Value.Dispose();
		}
		this.HLLIPGKLHMC.Clear();
		if (this.MQPNOMLJGKF != null)
		{
			this.IHBMCOINHHC();
		}
		this.BLBLQMCNEDM.Clear();
		this.EOFOHIGLKOQ.GHHIHHHCBNQ();
		this.NFONHGOGFHL.KPIBGJBMEBN();
		LGJGBKJCKPH.LPQIKIFQJMF();
	}

	// Token: 0x060069CB RID: 27083 RVA: 0x00027DB2 File Offset: 0x00025FB2
	public void CIIBNLGIJKD()
	{
		this.KKQOLNDNBOK.LFIDMKPQKKM();
		this.BQBEDGDPLCN.DIIHNJDHMGF();
		this.FFCHNPIPLQJ.KPECJMCFBJN();
	}

	// Token: 0x060069CC RID: 27084 RVA: 0x00346954 File Offset: 0x00344B54
	private void HKOCNGGKEDB()
	{
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			if (!this.LEOPCCDFEDD && this.KKQOLNDNBOK.NGQJLIEBFOM && !this.MQPNOMLJGKF.debugViews.QHKKOJMCFKQ())
			{
				this.FCPEIDMLEJC.LNCKNGKGHLN.ResetProjectionMatrix();
			}
			return;
		}
	}

	// Token: 0x060069CD RID: 27085 RVA: 0x003469B8 File Offset: 0x00344BB8
	private void NECHOJOEIFH()
	{
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			if (!this.LEOPCCDFEDD && this.KKQOLNDNBOK.NGQJLIEBFOM && !this.MQPNOMLJGKF.debugViews.DIQKLNLEJCF())
			{
				this.FCPEIDMLEJC.LNCKNGKGHLN.ResetProjectionMatrix();
			}
			return;
		}
	}

	// Token: 0x060069CE RID: 27086 RVA: 0x00345328 File Offset: 0x00343528
	private void NPLIDOPINDE()
	{
		foreach (JBGLEFPOLGP jbglefpolgp in this.BLBLQMCNEDM)
		{
			PostProcessingModel postProcessingModel = jbglefpolgp.CEKEFONEMIK();
			if (postProcessingModel != null && postProcessingModel.enabled)
			{
				jbglefpolgp.MEGLEJHOGQK();
			}
		}
	}

	// Token: 0x060069CF RID: 27087 RVA: 0x00027DD5 File Offset: 0x00025FD5
	public void OBJJNQHIDQQ()
	{
		this.KKQOLNDNBOK.LFIDMKPQKKM();
		this.BQBEDGDPLCN.PFHNDLKEHEP();
		this.FFCHNPIPLQJ.JODCDMDCLFD();
	}

	// Token: 0x060069D0 RID: 27088 RVA: 0x00345328 File Offset: 0x00343528
	private void JNIMNPFGDQG()
	{
		foreach (JBGLEFPOLGP jbglefpolgp in this.BLBLQMCNEDM)
		{
			PostProcessingModel postProcessingModel = jbglefpolgp.CEKEFONEMIK();
			if (postProcessingModel != null && postProcessingModel.enabled)
			{
				jbglefpolgp.MEGLEJHOGQK();
			}
		}
	}

	// Token: 0x060069D1 RID: 27089 RVA: 0x00346A1C File Offset: 0x00344C1C
	private void NBEMJHQNBCP<T>(NHOOQNHPFOB<T> EPOHMKPHHEM) where T : PostProcessingModel
	{
		if (EPOHMKPHHEM.NGQJLIEBFOM)
		{
			CommandBuffer commandBuffer = this.GBKNHOGECLJ<T>(EPOHMKPHHEM.KHFMCINEPGH(), EPOHMKPHHEM.QPDGCILDFLP());
			commandBuffer.Clear();
			EPOHMKPHHEM.EIQKCDHPCKK(commandBuffer);
		}
		else
		{
			this.KBLKQKIBLDJ<T>();
		}
	}

	// Token: 0x060069D2 RID: 27090 RVA: 0x00345328 File Offset: 0x00343528
	private void IHBMCOINHHC()
	{
		foreach (JBGLEFPOLGP jbglefpolgp in this.BLBLQMCNEDM)
		{
			PostProcessingModel postProcessingModel = jbglefpolgp.CEKEFONEMIK();
			if (postProcessingModel != null && postProcessingModel.enabled)
			{
				jbglefpolgp.MEGLEJHOGQK();
			}
		}
	}

	// Token: 0x060069D4 RID: 27092 RVA: 0x00027E16 File Offset: 0x00026016
	public void NDEEGQMDOGC()
	{
		this.KKQOLNDNBOK.KPECJMCFBJN();
		this.BQBEDGDPLCN.KPECJMCFBJN();
		this.FFCHNPIPLQJ.KPECJMCFBJN();
	}

	// Token: 0x060069D5 RID: 27093 RVA: 0x00027E39 File Offset: 0x00026039
	public void PNLDEIBHEKQ()
	{
		this.KKQOLNDNBOK.LFIDMKPQKKM();
		this.BQBEDGDPLCN.DIIHNJDHMGF();
		this.FFCHNPIPLQJ.OGPKBJBLPGP();
	}

	// Token: 0x060069D6 RID: 27094 RVA: 0x00346A5C File Offset: 0x00344C5C
	private void IGNQPODIKKH()
	{
		if (Event.current.type != EventType.KeyDown)
		{
			return;
		}
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			if (this.FFCHNPIPLQJ.NGQJLIEBFOM && this.MQPNOMLJGKF.debugViews.MFMGQGBEONI(BuiltinDebugViewsModel.HMFGKHHHIPL.PreGradingLog))
			{
				this.FFCHNPIPLQJ.OBCBHELFKHK();
			}
			else if (this.DOCNMEJBPOJ.NGQJLIEBFOM && this.MQPNOMLJGKF.debugViews.EKLOGKFNJHB(BuiltinDebugViewsModel.HMFGKHHHIPL.LogLut))
			{
				this.DOCNMEJBPOJ.PEJDIMKKHEH();
			}
			else if (this.OINFDKKBFEE.NGQJLIEBFOM && this.MQPNOMLJGKF.debugViews.CQIPKNHQKQO((BuiltinDebugViewsModel.HMFGKHHHIPL)115))
			{
				this.OINFDKKBFEE.FDMJHMNHKDI();
			}
			return;
		}
	}

	// Token: 0x060069D7 RID: 27095 RVA: 0x00345328 File Offset: 0x00343528
	private void JPILCMCPJEB()
	{
		foreach (JBGLEFPOLGP jbglefpolgp in this.BLBLQMCNEDM)
		{
			PostProcessingModel postProcessingModel = jbglefpolgp.CEKEFONEMIK();
			if (postProcessingModel != null && postProcessingModel.enabled)
			{
				jbglefpolgp.MEGLEJHOGQK();
			}
		}
	}

	// Token: 0x060069D8 RID: 27096 RVA: 0x00346B20 File Offset: 0x00344D20
	private void ODPLLOOLHCJ()
	{
		foreach (KeyValuePair<JBGLEFPOLGP, bool> keyValuePair in this.LHIGHGONHGQ)
		{
			JBGLEFPOLGP key = keyValuePair.Key;
			bool enabled;
			if ((enabled = key.CEKEFONEMIK().enabled) != keyValuePair.Value)
			{
				if (enabled)
				{
					this.JQIPPDCFBIK.Add(key);
				}
				else
				{
					this.KMFNKJIDLBP.Add(key);
				}
			}
		}
		for (int i = 1; i < this.KMFNKJIDLBP.Count; i++)
		{
			JBGLEFPOLGP jbglefpolgp = this.KMFNKJIDLBP[i];
			this.LHIGHGONHGQ[jbglefpolgp] = false;
			jbglefpolgp.MEGLEJHOGQK();
		}
		for (int j = 1; j < this.JQIPPDCFBIK.Count; j += 0)
		{
			JBGLEFPOLGP jbglefpolgp2 = this.JQIPPDCFBIK[j];
			this.LHIGHGONHGQ[jbglefpolgp2] = false;
			jbglefpolgp2.MNIFEBDOGKD();
		}
		this.KMFNKJIDLBP.Clear();
		this.JQIPPDCFBIK.Clear();
	}

	// Token: 0x060069D9 RID: 27097 RVA: 0x00346C3C File Offset: 0x00344E3C
	private void KBLKQKIBLDJ<T>() where T : PostProcessingModel
	{
		Type typeFromHandle = typeof(T);
		KeyValuePair<CameraEvent, CommandBuffer> keyValuePair;
		if (!this.HLLIPGKLHMC.TryGetValue(typeFromHandle, out keyValuePair))
		{
			return;
		}
		this.HIJBBBEQPLF.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
		this.HLLIPGKLHMC.Remove(typeFromHandle);
		keyValuePair.Value.Dispose();
	}

	// Token: 0x060069DA RID: 27098 RVA: 0x00345F14 File Offset: 0x00344114
	private void DOGHNJLQJOF()
	{
		this.HLLIPGKLHMC = new Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>>();
		this.EOFOHIGLKOQ = new HCKCDDQBDQD();
		this.NFONHGOGFHL = new PIJIQKMKDPO();
		this.FCPEIDMLEJC = new NNLOOFHPMNG();
		this.BLBLQMCNEDM = new List<JBGLEFPOLGP>();
		this.HDOQLDEJOMG = this.MJBLILJEBKC<MCBPLMFFGJC>(new MCBPLMFFGJC());
		this.CMMKNCCBMPJ = this.MJBLILJEBKC<FCJPPQICFGF>(new FCJPPQICFGF());
		this.DGQNIOMQHHO = this.MJBLILJEBKC<NHGDDFNJIPM>(new NHGDDFNJIPM());
		this.GPIFGGIHBPP = this.MJBLILJEBKC<KEIGFGDMQBF>(new KEIGFGDMQBF());
		this.BQBEDGDPLCN = this.MJBLILJEBKC<JKKJMOGLOOL>(new JKKJMOGLOOL());
		this.KKQOLNDNBOK = this.MJBLILJEBKC<FOFDHFBCNKC>(new FOFDHFBCNKC());
		this.FFCHNPIPLQJ = this.MJBLILJEBKC<KDMBLOFFMFG>(new KDMBLOFFMFG());
		this.OLHEDDBCEME = this.MJBLILJEBKC<LFEMGHQGCKK>(new LFEMGHQGCKK());
		this.CNEPCMCNGGG = this.MJBLILJEBKC<BJMBMMBMQHQ>(new BJMBMMBMQHQ());
		this.KLKFKEDBNHP = this.MJBLILJEBKC<QHPGHOFCBQD>(new QHPGHOFCBQD());
		this.DOCNMEJBPOJ = this.MJBLILJEBKC<KBCEDGOCEJQ>(new KBCEDGOCEJQ());
		this.OINFDKKBFEE = this.MJBLILJEBKC<JNLLDFGOFKP>(new JNLLDFGOFKP());
		this.MDLQNNDBIMB = this.MJBLILJEBKC<FFMEDEIIJOC>(new FFMEDEIIJOC());
		this.CPBJPCLLDGH = this.MJBLILJEBKC<NIJBPFMLQMP>(new NIJBPFMLQMP());
		this.KPDQEIOILLE = this.MJBLILJEBKC<LQHLOGDKHCQ>(new LQHLOGDKHCQ());
		this.LMLMMOOLNFE = this.MJBLILJEBKC<LJMJFHFGPJK>(new LJMJFHFGPJK());
		this.LHIGHGONHGQ = new Dictionary<JBGLEFPOLGP, bool>();
		foreach (JBGLEFPOLGP key in this.BLBLQMCNEDM)
		{
			this.LHIGHGONHGQ.Add(key, false);
		}
		base.useGUILayout = true;
	}

	// Token: 0x060069DB RID: 27099 RVA: 0x00346C98 File Offset: 0x00344E98
	private void MPGCOIIOIKG()
	{
		this.HIJBBBEQPLF = base.GetComponent<Camera>();
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			NNLOOFHPMNG nnloofhpmng = this.FCPEIDMLEJC.LCHMIMEBQGM();
			nnloofhpmng.MQPNOMLJGKF = this.MQPNOMLJGKF;
			nnloofhpmng.QKMKFPCOPEF = this.NFONHGOGFHL;
			nnloofhpmng.GOQBDJHFOPK = this.EOFOHIGLKOQ;
			nnloofhpmng.LNCKNGKGHLN = this.HIJBBBEQPLF;
			this.HDOQLDEJOMG.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.debugViews);
			this.CMMKNCCBMPJ.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.ambientOcclusion);
			this.DGQNIOMQHHO.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.screenSpaceReflection);
			this.GPIFGGIHBPP.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.fog);
			this.BQBEDGDPLCN.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.motionBlur);
			this.KKQOLNDNBOK.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.antialiasing);
			this.FFCHNPIPLQJ.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.eyeAdaptation);
			this.OLHEDDBCEME.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.depthOfField);
			this.CNEPCMCNGGG.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.bloom);
			this.KLKFKEDBNHP.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.chromaticAberration);
			this.DOCNMEJBPOJ.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.colorGrading);
			this.OINFDKKBFEE.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.userLut);
			this.MDLQNNDBIMB.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.grain);
			this.CPBJPCLLDGH.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.vignette);
			this.KPDQEIOILLE.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.dithering);
			this.LMLMMOOLNFE.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.antialiasing);
			if (this.FCJJPMPILMN != this.MQPNOMLJGKF)
			{
				this.IHBMCOINHHC();
				this.FCJJPMPILMN = this.MQPNOMLJGKF;
			}
			this.GIOLKPFOOMD();
			DepthTextureMode depthTextureMode = nnloofhpmng.LNCKNGKGHLN.depthTextureMode;
			foreach (JBGLEFPOLGP jbglefpolgp in this.BLBLQMCNEDM)
			{
				if (jbglefpolgp.NGQJLIEBFOM)
				{
					depthTextureMode |= jbglefpolgp.FDQNPDGFNHH();
				}
			}
			nnloofhpmng.LNCKNGKGHLN.depthTextureMode = depthTextureMode;
			if (!this.LEOPCCDFEDD && this.KKQOLNDNBOK.NGQJLIEBFOM && !this.MQPNOMLJGKF.debugViews.EJECHOPMOLJ())
			{
				this.KKQOLNDNBOK.PLEJDCFBKLC(this.NQNMOEDDOQN);
			}
			return;
		}
	}

	// Token: 0x060069DC RID: 27100 RVA: 0x00346F4C File Offset: 0x0034514C
	private void HQGIKLCMHPP(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			bool flag = false;
			bool ngqjliebfom = this.LMLMMOOLNFE.NGQJLIEBFOM;
			bool flag2 = this.KKQOLNDNBOK.NGQJLIEBFOM && this.LEOPCCDFEDD;
			bool flag3 = this.OLHEDDBCEME.NGQJLIEBFOM && !this.LEOPCCDFEDD;
			Material material = this.EOFOHIGLKOQ.DHLOEEOKKCL("Temp Sound Clip");
			material.shaderKeywords = null;
			RenderTexture renderTexture = PBHPQFLMQDB;
			if (flag2)
			{
				RenderTexture renderTexture2 = this.NFONHGOGFHL.INJNQNMOKKD(renderTexture);
				this.KKQOLNDNBOK.KOGLCCNQJIC(renderTexture, renderTexture2);
				renderTexture = renderTexture2;
			}
			Texture texture = LGJGBKJCKPH.BHNJCHPOBIE;
			if (this.FFCHNPIPLQJ.NGQJLIEBFOM)
			{
				flag = true;
				texture = this.FFCHNPIPLQJ.MLFHCLPMMLJ(renderTexture, material);
			}
			material.SetTexture(" is not a boolean array", texture);
			if (flag3)
			{
				flag = true;
				this.OLHEDDBCEME.GECNLHMHNCN(renderTexture, material, flag2, this.KKQOLNDNBOK.CGLOQGHDLEF, this.KKQOLNDNBOK.FIFNHCKNDQE.INPGLPEDINQ().taaSettings.motionBlending);
			}
			if (this.CNEPCMCNGGG.NGQJLIEBFOM)
			{
				flag = true;
				this.CNEPCMCNGGG.DFLOLMMCGID(renderTexture, material, texture);
			}
			flag = (flag | this.QGCELBLJPHK<ChromaticAberrationModel>(this.KLKFKEDBNHP, material) | this.QGCELBLJPHK<ColorGradingModel>(this.DOCNMEJBPOJ, material) | this.QGCELBLJPHK<VignetteModel>(this.CPBJPCLLDGH, material) | this.QGCELBLJPHK<UserLutModel>(this.OINFDKKBFEE, material));
			Material material2 = (!ngqjliebfom) ? null : this.EOFOHIGLKOQ.MFOCNQMDJGM("Moves can be used on the target regardless of its Abilities.");
			if (ngqjliebfom)
			{
				material2.shaderKeywords = null;
				this.QGCELBLJPHK<GrainModel>(this.MDLQNNDBIMB, material2);
				this.QGCELBLJPHK<DitheringModel>(this.KPDQEIOILLE, material2);
				if (flag)
				{
					RenderTexture renderTexture3 = this.NFONHGOGFHL.DNKGKNNMFBC(renderTexture);
					Graphics.Blit(renderTexture, renderTexture3, material, 1);
					renderTexture = renderTexture3;
				}
				this.LMLMMOOLNFE.BIPENHIDFOK(renderTexture, OBEPQQEKFLC);
			}
			else if (flag = (flag | this.QGCELBLJPHK<GrainModel>(this.MDLQNNDBIMB, material) | this.QGCELBLJPHK<DitheringModel>(this.KPDQEIOILLE, material)))
			{
				if (!LGJGBKJCKPH.HDMIHMIGIKJ)
				{
					material.EnableKeyword("1");
				}
				Graphics.Blit(renderTexture, OBEPQQEKFLC, material, 0);
			}
			if (!flag && !ngqjliebfom)
			{
				Graphics.Blit(renderTexture, OBEPQQEKFLC);
			}
			this.NFONHGOGFHL.DJECKELDOFE();
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x060069DD RID: 27101 RVA: 0x003471B4 File Offset: 0x003453B4
	private void CDHMEEGPFFL()
	{
		foreach (KeyValuePair<CameraEvent, CommandBuffer> keyValuePair in this.HLLIPGKLHMC.Values)
		{
			this.HIJBBBEQPLF.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
			keyValuePair.Value.Dispose();
		}
		this.HLLIPGKLHMC.Clear();
		if (this.MQPNOMLJGKF != null)
		{
			this.OQICNFPMFME();
		}
		this.BLBLQMCNEDM.Clear();
		this.EOFOHIGLKOQ.GCNLNGOJPFH();
		this.NFONHGOGFHL.ECGDGNFJPBO();
		LGJGBKJCKPH.LPQIKIFQJMF();
	}

	// Token: 0x060069DE RID: 27102 RVA: 0x003456B4 File Offset: 0x003438B4
	private void FEBGOGBDJIM()
	{
		if (this.MQPNOMLJGKF == null)
		{
			return;
		}
		this.NBEMJHQNBCP<BuiltinDebugViewsModel>(this.HDOQLDEJOMG);
		this.NBEMJHQNBCP<AmbientOcclusionModel>(this.CMMKNCCBMPJ);
		this.NBEMJHQNBCP<ScreenSpaceReflectionModel>(this.DGQNIOMQHHO);
		this.NBEMJHQNBCP<FogModel>(this.GPIFGGIHBPP);
		if (!this.LEOPCCDFEDD)
		{
			this.NBEMJHQNBCP<MotionBlurModel>(this.BQBEDGDPLCN);
		}
	}

	// Token: 0x060069DF RID: 27103 RVA: 0x00347270 File Offset: 0x00345470
	private void CJFHQQNKKCB()
	{
		foreach (KeyValuePair<CameraEvent, CommandBuffer> keyValuePair in this.HLLIPGKLHMC.Values)
		{
			this.HIJBBBEQPLF.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
			keyValuePair.Value.Dispose();
		}
		this.HLLIPGKLHMC.Clear();
		if (this.MQPNOMLJGKF != null)
		{
			this.NPLIDOPINDE();
		}
		this.BLBLQMCNEDM.Clear();
		this.EOFOHIGLKOQ.JQNCDLBMBKI();
		this.NFONHGOGFHL.NJEHMLKGJHG();
		LGJGBKJCKPH.LPQIKIFQJMF();
	}

	// Token: 0x060069E0 RID: 27104 RVA: 0x0034732C File Offset: 0x0034552C
	private void LMJQNHKOKPE()
	{
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			if (!this.LEOPCCDFEDD && this.KKQOLNDNBOK.NGQJLIEBFOM && !this.MQPNOMLJGKF.debugViews.IOHHGDDCHHD())
			{
				this.FCPEIDMLEJC.LNCKNGKGHLN.ResetProjectionMatrix();
			}
			return;
		}
	}

	// Token: 0x060069E1 RID: 27105 RVA: 0x00345328 File Offset: 0x00343528
	private void DGKCGICDIOO()
	{
		foreach (JBGLEFPOLGP jbglefpolgp in this.BLBLQMCNEDM)
		{
			PostProcessingModel postProcessingModel = jbglefpolgp.CEKEFONEMIK();
			if (postProcessingModel != null && postProcessingModel.enabled)
			{
				jbglefpolgp.MEGLEJHOGQK();
			}
		}
	}

	// Token: 0x060069E2 RID: 27106 RVA: 0x00347390 File Offset: 0x00345590
	private void JMJOCIGFJQQ()
	{
		if (Event.current.type != EventType.KeyDown)
		{
			return;
		}
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			if (this.FFCHNPIPLQJ.NGQJLIEBFOM && this.MQPNOMLJGKF.debugViews.NHJLBCFQCGD(BuiltinDebugViewsModel.HMFGKHHHIPL.None))
			{
				this.FFCHNPIPLQJ.NFFQELLLJEJ();
			}
			else if (this.DOCNMEJBPOJ.NGQJLIEBFOM && this.MQPNOMLJGKF.debugViews.KKQGGHQDMCP(BuiltinDebugViewsModel.HMFGKHHHIPL.Normals))
			{
				this.DOCNMEJBPOJ.PEJDIMKKHEH();
			}
			else if (this.OINFDKKBFEE.NGQJLIEBFOM && this.MQPNOMLJGKF.debugViews.NHJLBCFQCGD((BuiltinDebugViewsModel.HMFGKHHHIPL)30))
			{
				this.OINFDKKBFEE.CHOBOLIKNJM();
			}
			return;
		}
	}

	// Token: 0x060069E3 RID: 27107 RVA: 0x003456B4 File Offset: 0x003438B4
	private void CCODLQEDHHF()
	{
		if (this.MQPNOMLJGKF == null)
		{
			return;
		}
		this.NBEMJHQNBCP<BuiltinDebugViewsModel>(this.HDOQLDEJOMG);
		this.NBEMJHQNBCP<AmbientOcclusionModel>(this.CMMKNCCBMPJ);
		this.NBEMJHQNBCP<ScreenSpaceReflectionModel>(this.DGQNIOMQHHO);
		this.NBEMJHQNBCP<FogModel>(this.GPIFGGIHBPP);
		if (!this.LEOPCCDFEDD)
		{
			this.NBEMJHQNBCP<MotionBlurModel>(this.BQBEDGDPLCN);
		}
	}

	// Token: 0x060069E4 RID: 27108 RVA: 0x00347454 File Offset: 0x00345654
	private void KOIGOFPQHJN()
	{
		if (Event.current.type != EventType.KeyDown)
		{
			return;
		}
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			if (this.FFCHNPIPLQJ.NGQJLIEBFOM && this.MQPNOMLJGKF.debugViews.BNENBGDFIBD(BuiltinDebugViewsModel.HMFGKHHHIPL.Normals))
			{
				this.FFCHNPIPLQJ.OBCBHELFKHK();
			}
			else if (this.DOCNMEJBPOJ.NGQJLIEBFOM && this.MQPNOMLJGKF.debugViews.EKLOGKFNJHB(BuiltinDebugViewsModel.HMFGKHHHIPL.Normals))
			{
				this.DOCNMEJBPOJ.JOODKIHMODG();
			}
			else if (this.OINFDKKBFEE.NGQJLIEBFOM && this.MQPNOMLJGKF.debugViews.JMMJGNMOPLE((BuiltinDebugViewsModel.HMFGKHHHIPL)104))
			{
				this.OINFDKKBFEE.FDMJHMNHKDI();
			}
			return;
		}
	}

	// Token: 0x060069E5 RID: 27109 RVA: 0x00347518 File Offset: 0x00345718
	private void IPOJIEGOQFN()
	{
		foreach (KeyValuePair<CameraEvent, CommandBuffer> keyValuePair in this.HLLIPGKLHMC.Values)
		{
			this.HIJBBBEQPLF.RemoveCommandBuffer(keyValuePair.Key, keyValuePair.Value);
			keyValuePair.Value.Dispose();
		}
		this.HLLIPGKLHMC.Clear();
		if (this.MQPNOMLJGKF != null)
		{
			this.NPLIDOPINDE();
		}
		this.BLBLQMCNEDM.Clear();
		this.EOFOHIGLKOQ.CPKQJJNBMKB();
		this.NFONHGOGFHL.HEJBQLMOONQ();
		LGJGBKJCKPH.LPQIKIFQJMF();
	}

	// Token: 0x060069E6 RID: 27110 RVA: 0x003475D4 File Offset: 0x003457D4
	private void OnPostRender()
	{
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			if (!this.LEOPCCDFEDD && this.KKQOLNDNBOK.NGQJLIEBFOM && !this.MQPNOMLJGKF.debugViews.willInterrupt)
			{
				this.FCPEIDMLEJC.LNCKNGKGHLN.ResetProjectionMatrix();
			}
			return;
		}
	}

	// Token: 0x060069E7 RID: 27111 RVA: 0x00347638 File Offset: 0x00345838
	private void FIBNPEOLGJC()
	{
		this.HIJBBBEQPLF = base.GetComponent<Camera>();
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			NNLOOFHPMNG nnloofhpmng = this.FCPEIDMLEJC.BIFDELJCEQP();
			nnloofhpmng.MQPNOMLJGKF = this.MQPNOMLJGKF;
			nnloofhpmng.QKMKFPCOPEF = this.NFONHGOGFHL;
			nnloofhpmng.GOQBDJHFOPK = this.EOFOHIGLKOQ;
			nnloofhpmng.LNCKNGKGHLN = this.HIJBBBEQPLF;
			this.HDOQLDEJOMG.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.debugViews);
			this.CMMKNCCBMPJ.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.ambientOcclusion);
			this.DGQNIOMQHHO.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.screenSpaceReflection);
			this.GPIFGGIHBPP.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.fog);
			this.BQBEDGDPLCN.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.motionBlur);
			this.KKQOLNDNBOK.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.antialiasing);
			this.FFCHNPIPLQJ.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.eyeAdaptation);
			this.OLHEDDBCEME.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.depthOfField);
			this.CNEPCMCNGGG.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.bloom);
			this.KLKFKEDBNHP.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.chromaticAberration);
			this.DOCNMEJBPOJ.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.colorGrading);
			this.OINFDKKBFEE.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.userLut);
			this.MDLQNNDBIMB.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.grain);
			this.CPBJPCLLDGH.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.vignette);
			this.KPDQEIOILLE.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.dithering);
			this.LMLMMOOLNFE.CPCICJDOELQ(nnloofhpmng, this.MQPNOMLJGKF.antialiasing);
			if (this.FCJJPMPILMN != this.MQPNOMLJGKF)
			{
				this.BPJMQHHCEFG();
				this.FCJJPMPILMN = this.MQPNOMLJGKF;
			}
			this.BFJOKQOHKNP();
			DepthTextureMode depthTextureMode = nnloofhpmng.LNCKNGKGHLN.depthTextureMode;
			foreach (JBGLEFPOLGP jbglefpolgp in this.BLBLQMCNEDM)
			{
				if (jbglefpolgp.NGQJLIEBFOM)
				{
					depthTextureMode |= jbglefpolgp.FDQNPDGFNHH();
				}
			}
			nnloofhpmng.LNCKNGKGHLN.depthTextureMode = depthTextureMode;
			if (!this.LEOPCCDFEDD && this.KKQOLNDNBOK.NGQJLIEBFOM && !this.MQPNOMLJGKF.debugViews.DLGQEBCLOHE())
			{
				this.KKQOLNDNBOK.GMPBDDDCIHK(this.NQNMOEDDOQN);
			}
			return;
		}
	}

	// Token: 0x060069E8 RID: 27112 RVA: 0x00345328 File Offset: 0x00343528
	private void FOPQGBCKBPM()
	{
		foreach (JBGLEFPOLGP jbglefpolgp in this.BLBLQMCNEDM)
		{
			PostProcessingModel postProcessingModel = jbglefpolgp.CEKEFONEMIK();
			if (postProcessingModel != null && postProcessingModel.enabled)
			{
				jbglefpolgp.MEGLEJHOGQK();
			}
		}
	}

	// Token: 0x060069E9 RID: 27113 RVA: 0x00027E5C File Offset: 0x0002605C
	private T MJBLILJEBKC<T>(T EPOHMKPHHEM) where T : JBGLEFPOLGP
	{
		this.BLBLQMCNEDM.Add(EPOHMKPHHEM);
		return EPOHMKPHHEM;
	}

	// Token: 0x060069EA RID: 27114 RVA: 0x00345328 File Offset: 0x00343528
	private void BPJMQHHCEFG()
	{
		foreach (JBGLEFPOLGP jbglefpolgp in this.BLBLQMCNEDM)
		{
			PostProcessingModel postProcessingModel = jbglefpolgp.CEKEFONEMIK();
			if (postProcessingModel != null && postProcessingModel.enabled)
			{
				jbglefpolgp.MEGLEJHOGQK();
			}
		}
	}

	// Token: 0x060069EB RID: 27115 RVA: 0x00027E70 File Offset: 0x00026070
	public void JDQDHCJLQLE()
	{
		this.KKQOLNDNBOK.KPECJMCFBJN();
		this.BQBEDGDPLCN.DIIHNJDHMGF();
		this.FFCHNPIPLQJ.FDFLIPMMEQD();
	}

	// Token: 0x060069EC RID: 27116 RVA: 0x003456B4 File Offset: 0x003438B4
	private void MOEMIBJDKLF()
	{
		if (this.MQPNOMLJGKF == null)
		{
			return;
		}
		this.NBEMJHQNBCP<BuiltinDebugViewsModel>(this.HDOQLDEJOMG);
		this.NBEMJHQNBCP<AmbientOcclusionModel>(this.CMMKNCCBMPJ);
		this.NBEMJHQNBCP<ScreenSpaceReflectionModel>(this.DGQNIOMQHHO);
		this.NBEMJHQNBCP<FogModel>(this.GPIFGGIHBPP);
		if (!this.LEOPCCDFEDD)
		{
			this.NBEMJHQNBCP<MotionBlurModel>(this.BQBEDGDPLCN);
		}
	}

	// Token: 0x060069ED RID: 27117 RVA: 0x003478EC File Offset: 0x00345AEC
	private void OnGUI()
	{
		if (Event.current.type != EventType.Repaint)
		{
			return;
		}
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			if (this.FFCHNPIPLQJ.NGQJLIEBFOM && this.MQPNOMLJGKF.debugViews.CQIPKNHQKQO(BuiltinDebugViewsModel.HMFGKHHHIPL.EyeAdaptation))
			{
				this.FFCHNPIPLQJ.HDPLJPCCCOH();
			}
			else if (this.DOCNMEJBPOJ.NGQJLIEBFOM && this.MQPNOMLJGKF.debugViews.CQIPKNHQKQO(BuiltinDebugViewsModel.HMFGKHHHIPL.LogLut))
			{
				this.DOCNMEJBPOJ.HDPLJPCCCOH();
			}
			else if (this.OINFDKKBFEE.NGQJLIEBFOM && this.MQPNOMLJGKF.debugViews.CQIPKNHQKQO(BuiltinDebugViewsModel.HMFGKHHHIPL.UserLut))
			{
				this.OINFDKKBFEE.HDPLJPCCCOH();
			}
			return;
		}
	}

	// Token: 0x060069EE RID: 27118 RVA: 0x00345328 File Offset: 0x00343528
	private void OQICNFPMFME()
	{
		foreach (JBGLEFPOLGP jbglefpolgp in this.BLBLQMCNEDM)
		{
			PostProcessingModel postProcessingModel = jbglefpolgp.CEKEFONEMIK();
			if (postProcessingModel != null && postProcessingModel.enabled)
			{
				jbglefpolgp.MEGLEJHOGQK();
			}
		}
	}

	// Token: 0x060069EF RID: 27119 RVA: 0x003479B0 File Offset: 0x00345BB0
	private void CHHICIOJFLI(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			bool flag = true;
			bool ngqjliebfom = this.LMLMMOOLNFE.NGQJLIEBFOM;
			bool flag2 = !this.KKQOLNDNBOK.NGQJLIEBFOM || !this.LEOPCCDFEDD;
			bool flag3 = this.OLHEDDBCEME.NGQJLIEBFOM && this.LEOPCCDFEDD;
			Material material = this.EOFOHIGLKOQ.NONHJLIJQIP("powersplit");
			material.shaderKeywords = null;
			RenderTexture renderTexture = PBHPQFLMQDB;
			if (flag2)
			{
				RenderTexture renderTexture2 = this.NFONHGOGFHL.ODOJHJGHDNO(renderTexture);
				this.KKQOLNDNBOK.ILCMMJMCPIE(renderTexture, renderTexture2);
				renderTexture = renderTexture2;
			}
			Texture texture = LGJGBKJCKPH.BHNJCHPOBIE;
			if (this.FFCHNPIPLQJ.NGQJLIEBFOM)
			{
				flag = true;
				texture = this.FFCHNPIPLQJ.KJGHGLQFCEG(renderTexture, material);
			}
			material.SetTexture("tox", texture);
			if (flag3)
			{
				flag = false;
				this.OLHEDDBCEME.GCQOKKCDPFH(renderTexture, material, flag2, this.KKQOLNDNBOK.FHNJEEFNOOL(), this.KKQOLNDNBOK.FIFNHCKNDQE.settings.taaSettings.motionBlending);
			}
			if (this.CNEPCMCNGGG.NGQJLIEBFOM)
			{
				flag = false;
				this.CNEPCMCNGGG.ELHMEKCHNJE(renderTexture, material, texture);
			}
			flag = (flag | this.QGCELBLJPHK<ChromaticAberrationModel>(this.KLKFKEDBNHP, material) | this.QGCELBLJPHK<ColorGradingModel>(this.DOCNMEJBPOJ, material) | this.QGCELBLJPHK<VignetteModel>(this.CPBJPCLLDGH, material) | this.QGCELBLJPHK<UserLutModel>(this.OINFDKKBFEE, material));
			Material material2 = (!ngqjliebfom) ? null : this.EOFOHIGLKOQ.QDMHMMGFIOJ("2D UI");
			if (ngqjliebfom)
			{
				material2.shaderKeywords = null;
				this.QGCELBLJPHK<GrainModel>(this.MDLQNNDBIMB, material2);
				this.QGCELBLJPHK<DitheringModel>(this.KPDQEIOILLE, material2);
				if (flag)
				{
					RenderTexture renderTexture3 = this.NFONHGOGFHL.BCKHMJFJMNP(renderTexture);
					Graphics.Blit(renderTexture, renderTexture3, material, 1);
					renderTexture = renderTexture3;
				}
				this.LMLMMOOLNFE.NOODEMIFPPL(renderTexture, OBEPQQEKFLC);
			}
			else if (flag = (flag | this.QGCELBLJPHK<GrainModel>(this.MDLQNNDBIMB, material) | this.QGCELBLJPHK<DitheringModel>(this.KPDQEIOILLE, material)))
			{
				if (!LGJGBKJCKPH.HDMIHMIGIKJ)
				{
					material.EnableKeyword("You can not use buffs during interactions.");
				}
				Graphics.Blit(renderTexture, OBEPQQEKFLC, material, 1);
			}
			if (!flag && !ngqjliebfom)
			{
				Graphics.Blit(renderTexture, OBEPQQEKFLC);
			}
			this.NFONHGOGFHL.FMJFNIPHBCP();
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x060069F0 RID: 27120 RVA: 0x00347C18 File Offset: 0x00345E18
	private void BFJOKQOHKNP()
	{
		foreach (KeyValuePair<JBGLEFPOLGP, bool> keyValuePair in this.LHIGHGONHGQ)
		{
			JBGLEFPOLGP key = keyValuePair.Key;
			bool enabled;
			if ((enabled = key.CEKEFONEMIK().enabled) != keyValuePair.Value)
			{
				if (enabled)
				{
					this.JQIPPDCFBIK.Add(key);
				}
				else
				{
					this.KMFNKJIDLBP.Add(key);
				}
			}
		}
		for (int i = 1; i < this.KMFNKJIDLBP.Count; i += 0)
		{
			JBGLEFPOLGP jbglefpolgp = this.KMFNKJIDLBP[i];
			this.LHIGHGONHGQ[jbglefpolgp] = false;
			jbglefpolgp.MEGLEJHOGQK();
		}
		for (int j = 1; j < this.JQIPPDCFBIK.Count; j += 0)
		{
			JBGLEFPOLGP jbglefpolgp2 = this.JQIPPDCFBIK[j];
			this.LHIGHGONHGQ[jbglefpolgp2] = true;
			jbglefpolgp2.MNIFEBDOGKD();
		}
		this.KMFNKJIDLBP.Clear();
		this.JQIPPDCFBIK.Clear();
	}

	// Token: 0x060069F1 RID: 27121 RVA: 0x00347D34 File Offset: 0x00345F34
	private void CMBGCDIHCBC()
	{
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			if (!this.LEOPCCDFEDD && this.KKQOLNDNBOK.NGQJLIEBFOM && !this.MQPNOMLJGKF.debugViews.EJCBBLFFDFB())
			{
				this.FCPEIDMLEJC.LNCKNGKGHLN.ResetProjectionMatrix();
			}
			return;
		}
	}

	// Token: 0x060069F2 RID: 27122 RVA: 0x00027E70 File Offset: 0x00026070
	public void QKJEMQKNOKQ()
	{
		this.KKQOLNDNBOK.KPECJMCFBJN();
		this.BQBEDGDPLCN.DIIHNJDHMGF();
		this.FFCHNPIPLQJ.FDFLIPMMEQD();
	}

	// Token: 0x060069F3 RID: 27123 RVA: 0x00347D98 File Offset: 0x00345F98
	private CommandBuffer GBKNHOGECLJ<T>(CameraEvent EKMDMIDCEIM, string IHIHHCCEDHQ) where T : PostProcessingModel
	{
		KeyValuePair<CameraEvent, CommandBuffer> keyValuePair;
		CommandBuffer result;
		if (!this.HLLIPGKLHMC.TryGetValue(typeof(T), out keyValuePair))
		{
			result = this.MJBBKCQDGEI<T>(EKMDMIDCEIM, IHIHHCCEDHQ);
		}
		else if (keyValuePair.Key != EKMDMIDCEIM)
		{
			this.KBLKQKIBLDJ<T>();
			result = this.MJBBKCQDGEI<T>(EKMDMIDCEIM, IHIHHCCEDHQ);
		}
		else
		{
			result = keyValuePair.Value;
		}
		return result;
	}

	// Token: 0x060069F4 RID: 27124 RVA: 0x00347DF0 File Offset: 0x00345FF0
	private void BDOCJEKGHPC(RenderTexture PBHPQFLMQDB, RenderTexture OBEPQQEKFLC)
	{
		if (!(this.MQPNOMLJGKF == null) && !(this.HIJBBBEQPLF == null))
		{
			bool flag = true;
			bool ngqjliebfom = this.LMLMMOOLNFE.NGQJLIEBFOM;
			bool flag2 = !this.KKQOLNDNBOK.NGQJLIEBFOM || !this.LEOPCCDFEDD;
			bool flag3 = !this.OLHEDDBCEME.NGQJLIEBFOM || this.LEOPCCDFEDD;
			Material material = this.EOFOHIGLKOQ.KDQCHHNMPQD("_OcclusionTexture1");
			material.shaderKeywords = null;
			RenderTexture renderTexture = PBHPQFLMQDB;
			if (flag2)
			{
				RenderTexture renderTexture2 = this.NFONHGOGFHL.DNKGKNNMFBC(renderTexture);
				this.KKQOLNDNBOK.ILCMMJMCPIE(renderTexture, renderTexture2);
				renderTexture = renderTexture2;
			}
			Texture texture = LGJGBKJCKPH.BHNJCHPOBIE;
			if (this.FFCHNPIPLQJ.NGQJLIEBFOM)
			{
				flag = true;
				texture = this.FFCHNPIPLQJ.MLFHCLPMMLJ(renderTexture, material);
			}
			material.SetTexture("frz", texture);
			if (flag3)
			{
				flag = false;
				this.OLHEDDBCEME.OHOOHBNODFC(renderTexture, material, flag2, this.KKQOLNDNBOK.CGLOQGHDLEF, this.KKQOLNDNBOK.FIFNHCKNDQE.DCPMJDLDNMM().taaSettings.motionBlending);
			}
			if (this.CNEPCMCNGGG.NGQJLIEBFOM)
			{
				flag = false;
				this.CNEPCMCNGGG.DHMCJMEGFOE(renderTexture, material, texture);
			}
			flag = (flag | this.QGCELBLJPHK<ChromaticAberrationModel>(this.KLKFKEDBNHP, material) | this.QGCELBLJPHK<ColorGradingModel>(this.DOCNMEJBPOJ, material) | this.QGCELBLJPHK<VignetteModel>(this.CPBJPCLLDGH, material) | this.QGCELBLJPHK<UserLutModel>(this.OINFDKKBFEE, material));
			Material material2 = (!ngqjliebfom) ? null : this.EOFOHIGLKOQ.GBBDHLKHEOO("FOG_SUN_SHADOWS_ON");
			if (ngqjliebfom)
			{
				material2.shaderKeywords = null;
				this.QGCELBLJPHK<GrainModel>(this.MDLQNNDBIMB, material2);
				this.QGCELBLJPHK<DitheringModel>(this.KPDQEIOILLE, material2);
				if (flag)
				{
					RenderTexture renderTexture3 = this.NFONHGOGFHL.DNKGKNNMFBC(renderTexture);
					Graphics.Blit(renderTexture, renderTexture3, material, 0);
					renderTexture = renderTexture3;
				}
				this.LMLMMOOLNFE.CHQPHOGBBQI(renderTexture, OBEPQQEKFLC);
			}
			else if (flag = (flag | this.QGCELBLJPHK<GrainModel>(this.MDLQNNDBIMB, material) | this.QGCELBLJPHK<DitheringModel>(this.KPDQEIOILLE, material)))
			{
				if (!LGJGBKJCKPH.HDMIHMIGIKJ)
				{
					material.EnableKeyword("UpS");
				}
				Graphics.Blit(renderTexture, OBEPQQEKFLC, material, 0);
			}
			if (!flag && !ngqjliebfom)
			{
				Graphics.Blit(renderTexture, OBEPQQEKFLC);
			}
			this.NFONHGOGFHL.PIMHDLDBNGP();
			return;
		}
		Graphics.Blit(PBHPQFLMQDB, OBEPQQEKFLC);
	}

	// Token: 0x0400163F RID: 5695
	public PostProcessingProfile MQPNOMLJGKF;

	// Token: 0x04001640 RID: 5696
	public Func<Vector2, Matrix4x4> NQNMOEDDOQN;

	// Token: 0x04001641 RID: 5697
	private Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>> HLLIPGKLHMC;

	// Token: 0x04001642 RID: 5698
	private List<JBGLEFPOLGP> BLBLQMCNEDM;

	// Token: 0x04001643 RID: 5699
	private Dictionary<JBGLEFPOLGP, bool> LHIGHGONHGQ;

	// Token: 0x04001644 RID: 5700
	private HCKCDDQBDQD EOFOHIGLKOQ;

	// Token: 0x04001645 RID: 5701
	private PIJIQKMKDPO NFONHGOGFHL;

	// Token: 0x04001646 RID: 5702
	private NNLOOFHPMNG FCPEIDMLEJC;

	// Token: 0x04001647 RID: 5703
	private Camera HIJBBBEQPLF;

	// Token: 0x04001648 RID: 5704
	private PostProcessingProfile FCJJPMPILMN;

	// Token: 0x04001649 RID: 5705
	private bool LEOPCCDFEDD;

	// Token: 0x0400164A RID: 5706
	private MCBPLMFFGJC HDOQLDEJOMG;

	// Token: 0x0400164B RID: 5707
	private FCJPPQICFGF CMMKNCCBMPJ;

	// Token: 0x0400164C RID: 5708
	private NHGDDFNJIPM DGQNIOMQHHO;

	// Token: 0x0400164D RID: 5709
	private KEIGFGDMQBF GPIFGGIHBPP;

	// Token: 0x0400164E RID: 5710
	private JKKJMOGLOOL BQBEDGDPLCN;

	// Token: 0x0400164F RID: 5711
	private FOFDHFBCNKC KKQOLNDNBOK;

	// Token: 0x04001650 RID: 5712
	private KDMBLOFFMFG FFCHNPIPLQJ;

	// Token: 0x04001651 RID: 5713
	private LFEMGHQGCKK OLHEDDBCEME;

	// Token: 0x04001652 RID: 5714
	private BJMBMMBMQHQ CNEPCMCNGGG;

	// Token: 0x04001653 RID: 5715
	private QHPGHOFCBQD KLKFKEDBNHP;

	// Token: 0x04001654 RID: 5716
	private KBCEDGOCEJQ DOCNMEJBPOJ;

	// Token: 0x04001655 RID: 5717
	private JNLLDFGOFKP OINFDKKBFEE;

	// Token: 0x04001656 RID: 5718
	private FFMEDEIIJOC MDLQNNDBIMB;

	// Token: 0x04001657 RID: 5719
	private NIJBPFMLQMP CPBJPCLLDGH;

	// Token: 0x04001658 RID: 5720
	private LQHLOGDKHCQ KPDQEIOILLE;

	// Token: 0x04001659 RID: 5721
	private LJMJFHFGPJK LMLMMOOLNFE;

	// Token: 0x0400165A RID: 5722
	private List<JBGLEFPOLGP> JQIPPDCFBIK = new List<JBGLEFPOLGP>();

	// Token: 0x0400165B RID: 5723
	private List<JBGLEFPOLGP> KMFNKJIDLBP = new List<JBGLEFPOLGP>();
}
