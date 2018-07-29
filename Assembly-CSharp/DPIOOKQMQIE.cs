using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000378 RID: 888
[ExecuteInEditMode]
public class DPIOOKQMQIE : MonoBehaviour
{
	// Token: 0x06007614 RID: 30228 RVA: 0x0038A04C File Offset: 0x0038824C
	private void GMINPMQHEMH(RenderTexture MOECMOLDQKL, RenderTexture PNQFLLEDEGG)
	{
		if (!Mathf.Approximately(this.PJMOBJDCOCL, 1253f) && !(this.KQHLPFNJNND() == null))
		{
			if (Math.Abs(this.PJMOBJDCOCL - this.PNFNJMFMJPK) > 928f)
			{
				this.PJMOBJDCOCL = Mathf.Clamp01(this.PJMOBJDCOCL);
				this.PIMNBLHLHBI().SetFloat(this.LDKQKGKHCMM, 138f - this.PJMOBJDCOCL);
				this.GOQMQFJIJCN().SetFloat(this.CIPBCBLOJFM, this.PJMOBJDCOCL);
				this.KBQGBBBELMQ().SetColor(this.MMIJOJLELCH, this.LJLQMONMIKN);
			}
			Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG, this.KBQGBBBELMQ());
			this.PNFNJMFMJPK = this.PJMOBJDCOCL;
			return;
		}
		Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG);
	}

	// Token: 0x06007615 RID: 30229 RVA: 0x0038A118 File Offset: 0x00388318
	private Material DQLNEPDLDNG()
	{
		if (this.EEBLGHNHGID != null)
		{
			return this.EEBLGHNHGID;
		}
		this.EEBLGHNHGID = new Material(Shader.Find("[-]"))
		{
			hideFlags = (HideFlags)(-125)
		};
		return this.EEBLGHNHGID;
	}

	// Token: 0x06007616 RID: 30230 RVA: 0x0038A160 File Offset: 0x00388360
	private Material EGPEBNDHEBO()
	{
		if (this.EEBLGHNHGID != null)
		{
			return this.EEBLGHNHGID;
		}
		this.EEBLGHNHGID = new Material(Shader.Find("_ChannelMixerBlue"))
		{
			hideFlags = ~HideFlags.DontSaveInBuild
		};
		return this.EEBLGHNHGID;
	}

	// Token: 0x06007617 RID: 30231 RVA: 0x0038A1A8 File Offset: 0x003883A8
	private IEnumerator MNLEJBQBDGJ(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		float pjmobjdcocl = this.PJMOBJDCOCL;
		float num = 0f;
		if (num > 1f)
		{
			this.PJMOBJDCOCL = BPHOCDBPHDP;
			yield return null;
		}
		else
		{
			num += Time.deltaTime / CPKNEQGKQPQ;
			this.PJMOBJDCOCL = BDKMFJQPGGE.QEDDMFBJBQO(pjmobjdcocl, BPHOCDBPHDP, num, GMNJJQQPEDB.EaseOut);
			yield return null;
		}
		return 1;
		yield break;
	}

	// Token: 0x06007618 RID: 30232 RVA: 0x0038A1A8 File Offset: 0x003883A8
	private IEnumerator MLMKLILEBMM(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		pjmobjdcocl = this.PJMOBJDCOCL;
		num = 0f;
		if (num > 1f)
		{
			this.PJMOBJDCOCL = BPHOCDBPHDP;
			yield return null;
		}
		else
		{
			num += Time.deltaTime / CPKNEQGKQPQ;
			this.PJMOBJDCOCL = BDKMFJQPGGE.QEDDMFBJBQO(pjmobjdcocl, BPHOCDBPHDP, num, GMNJJQQPEDB.EaseOut);
			yield return null;
		}
		return 1;
		yield break;
	}

	// Token: 0x06007619 RID: 30233 RVA: 0x0038A1A8 File Offset: 0x003883A8
	private IEnumerator LKDDHLBHQJC(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		pjmobjdcocl = this.PJMOBJDCOCL;
		num = 0f;
		if (num > 1f)
		{
			this.PJMOBJDCOCL = BPHOCDBPHDP;
			yield return null;
		}
		else
		{
			num += Time.deltaTime / CPKNEQGKQPQ;
			this.PJMOBJDCOCL = BDKMFJQPGGE.QEDDMFBJBQO(pjmobjdcocl, BPHOCDBPHDP, num, GMNJJQQPEDB.EaseOut);
			yield return null;
		}
		return 1;
		yield break;
	}

	// Token: 0x0600761A RID: 30234 RVA: 0x0002A850 File Offset: 0x00028A50
	private void BNKGGNOQODC()
	{
		if (this.EEBLGHNHGID)
		{
			UnityEngine.Object.DestroyImmediate(this.EEBLGHNHGID);
		}
	}

	// Token: 0x0600761B RID: 30235 RVA: 0x0038A1A8 File Offset: 0x003883A8
	private IEnumerator OKDNMNJBDMQ(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		pjmobjdcocl = this.PJMOBJDCOCL;
		num = 0f;
		if (num > 1f)
		{
			this.PJMOBJDCOCL = BPHOCDBPHDP;
			yield return null;
		}
		else
		{
			num += Time.deltaTime / CPKNEQGKQPQ;
			this.PJMOBJDCOCL = BDKMFJQPGGE.QEDDMFBJBQO(pjmobjdcocl, BPHOCDBPHDP, num, GMNJJQQPEDB.EaseOut);
			yield return null;
		}
		return 1;
		yield break;
	}

	// Token: 0x0600761C RID: 30236 RVA: 0x0002A86A File Offset: 0x00028A6A
	public void INFECLKNNKK(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		base.StopAllCoroutines();
		base.StartCoroutine(this.MPQFLFFNIBH(BPHOCDBPHDP, CPKNEQGKQPQ));
	}

	// Token: 0x0600761D RID: 30237 RVA: 0x0002A850 File Offset: 0x00028A50
	private void BBDPHLPLFCP()
	{
		if (this.EEBLGHNHGID)
		{
			UnityEngine.Object.DestroyImmediate(this.EEBLGHNHGID);
		}
	}

	// Token: 0x0600761E RID: 30238 RVA: 0x0002A881 File Offset: 0x00028A81
	public void CNIFNPJPKPG(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		base.StopAllCoroutines();
		base.StartCoroutine(this.HNHKCJLOBGM(BPHOCDBPHDP, CPKNEQGKQPQ));
	}

	// Token: 0x0600761F RID: 30239 RVA: 0x0002A850 File Offset: 0x00028A50
	private void MHNMQLMILMQ()
	{
		if (this.EEBLGHNHGID)
		{
			UnityEngine.Object.DestroyImmediate(this.EEBLGHNHGID);
		}
	}

	// Token: 0x06007620 RID: 30240 RVA: 0x0002A86A File Offset: 0x00028A6A
	public void ONEOLDKPOBE(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		base.StopAllCoroutines();
		base.StartCoroutine(this.MPQFLFFNIBH(BPHOCDBPHDP, CPKNEQGKQPQ));
	}

	// Token: 0x06007621 RID: 30241 RVA: 0x0002A850 File Offset: 0x00028A50
	private void ENHLIHPIHKN()
	{
		if (this.EEBLGHNHGID)
		{
			UnityEngine.Object.DestroyImmediate(this.EEBLGHNHGID);
		}
	}

	// Token: 0x06007622 RID: 30242 RVA: 0x0038A1D4 File Offset: 0x003883D4
	private void DNCNQNKNJHD()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		this.PNFNJMFMJPK = 93f;
		if (this.LDKQKGKHCMM == 0)
		{
			this.LDKQKGKHCMM = Shader.PropertyToID("WATER_SIMPLE");
		}
		if (this.CIPBCBLOJFM == 0)
		{
			this.CIPBCBLOJFM = Shader.PropertyToID("(S)");
		}
		if (this.MMIJOJLELCH == 0)
		{
			this.MMIJOJLELCH = Shader.PropertyToID("_MainTex");
		}
	}

	// Token: 0x06007623 RID: 30243 RVA: 0x0038A244 File Offset: 0x00388444
	private Material CQIBJNKQHBH()
	{
		if (this.EEBLGHNHGID != null)
		{
			return this.EEBLGHNHGID;
		}
		this.EEBLGHNHGID = new Material(Shader.Find("_DetailScaleX"))
		{
			hideFlags = (HideFlags)(-111)
		};
		return this.EEBLGHNHGID;
	}

	// Token: 0x06007624 RID: 30244 RVA: 0x0038A28C File Offset: 0x0038848C
	private Material DNCEIFBHHNH()
	{
		if (this.EEBLGHNHGID != null)
		{
			return this.EEBLGHNHGID;
		}
		this.EEBLGHNHGID = new Material(Shader.Find("!\r\n"))
		{
			hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild)
		};
		return this.EEBLGHNHGID;
	}

	// Token: 0x06007625 RID: 30245 RVA: 0x0038A2D4 File Offset: 0x003884D4
	private void EOLBEDLCPHQ()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		this.PNFNJMFMJPK = 1481f;
		if (this.LDKQKGKHCMM == 0)
		{
			this.LDKQKGKHCMM = Shader.PropertyToID("(Qu)");
		}
		if (this.CIPBCBLOJFM == 0)
		{
			this.CIPBCBLOJFM = Shader.PropertyToID("It reduced the PP of ");
		}
		if (this.MMIJOJLELCH == 0)
		{
			this.MMIJOJLELCH = Shader.PropertyToID(" Obtained");
		}
	}

	// Token: 0x06007626 RID: 30246 RVA: 0x0038A344 File Offset: 0x00388544
	private Material KBQGBBBELMQ()
	{
		if (this.EEBLGHNHGID != null)
		{
			return this.EEBLGHNHGID;
		}
		this.EEBLGHNHGID = new Material(Shader.Find("System"))
		{
			hideFlags = (HideFlags)(-112)
		};
		return this.EEBLGHNHGID;
	}

	// Token: 0x06007627 RID: 30247 RVA: 0x0038A1A8 File Offset: 0x003883A8
	private IEnumerator IDMPEFOQBEG(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		pjmobjdcocl = this.PJMOBJDCOCL;
		num = 0f;
		if (num > 1f)
		{
			this.PJMOBJDCOCL = BPHOCDBPHDP;
			yield return null;
		}
		else
		{
			num += Time.deltaTime / CPKNEQGKQPQ;
			this.PJMOBJDCOCL = BDKMFJQPGGE.QEDDMFBJBQO(pjmobjdcocl, BPHOCDBPHDP, num, GMNJJQQPEDB.EaseOut);
			yield return null;
		}
		return 1;
		yield break;
	}

	// Token: 0x06007628 RID: 30248 RVA: 0x0038A38C File Offset: 0x0038858C
	private Material KFFIDNIGEIB()
	{
		if (this.EEBLGHNHGID != null)
		{
			return this.EEBLGHNHGID;
		}
		this.EEBLGHNHGID = new Material(Shader.Find("Blank"))
		{
			hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild)
		};
		return this.EEBLGHNHGID;
	}

	// Token: 0x06007629 RID: 30249 RVA: 0x0002A850 File Offset: 0x00028A50
	private void GHQMEKKBHOI()
	{
		if (this.EEBLGHNHGID)
		{
			UnityEngine.Object.DestroyImmediate(this.EEBLGHNHGID);
		}
	}

	// Token: 0x0600762A RID: 30250 RVA: 0x0038A1A8 File Offset: 0x003883A8
	private IEnumerator HIIJDNCKPBM(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		pjmobjdcocl = this.PJMOBJDCOCL;
		num = 0f;
		if (num > 1f)
		{
			this.PJMOBJDCOCL = BPHOCDBPHDP;
			yield return null;
		}
		else
		{
			num += Time.deltaTime / CPKNEQGKQPQ;
			this.PJMOBJDCOCL = BDKMFJQPGGE.QEDDMFBJBQO(pjmobjdcocl, BPHOCDBPHDP, num, GMNJJQQPEDB.EaseOut);
			yield return null;
		}
		return 1;
		yield break;
	}

	// Token: 0x0600762B RID: 30251 RVA: 0x0002A850 File Offset: 0x00028A50
	private void DCLCKPODOPN()
	{
		if (this.EEBLGHNHGID)
		{
			UnityEngine.Object.DestroyImmediate(this.EEBLGHNHGID);
		}
	}

	// Token: 0x0600762C RID: 30252 RVA: 0x0038A1A8 File Offset: 0x003883A8
	private IEnumerator CONQDJQNGNH(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		pjmobjdcocl = this.PJMOBJDCOCL;
		num = 0f;
		if (num > 1f)
		{
			this.PJMOBJDCOCL = BPHOCDBPHDP;
			yield return null;
		}
		else
		{
			num += Time.deltaTime / CPKNEQGKQPQ;
			this.PJMOBJDCOCL = BDKMFJQPGGE.QEDDMFBJBQO(pjmobjdcocl, BPHOCDBPHDP, num, GMNJJQQPEDB.EaseOut);
			yield return null;
		}
		return 1;
		yield break;
	}

	// Token: 0x0600762D RID: 30253 RVA: 0x0038A1A8 File Offset: 0x003883A8
	private IEnumerator KMLPKJFLEBI(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		pjmobjdcocl = this.PJMOBJDCOCL;
		num = 0f;
		if (num > 1f)
		{
			this.PJMOBJDCOCL = BPHOCDBPHDP;
			yield return null;
		}
		else
		{
			num += Time.deltaTime / CPKNEQGKQPQ;
			this.PJMOBJDCOCL = BDKMFJQPGGE.QEDDMFBJBQO(pjmobjdcocl, BPHOCDBPHDP, num, GMNJJQQPEDB.EaseOut);
			yield return null;
		}
		return 1;
		yield break;
	}

	// Token: 0x0600762E RID: 30254 RVA: 0x0038A3D4 File Offset: 0x003885D4
	private Material PIMNBLHLHBI()
	{
		if (this.EEBLGHNHGID != null)
		{
			return this.EEBLGHNHGID;
		}
		this.EEBLGHNHGID = new Material(Shader.Find("_VolumetricFogSunProj"))
		{
			hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild)
		};
		return this.EEBLGHNHGID;
	}

	// Token: 0x0600762F RID: 30255 RVA: 0x0002A850 File Offset: 0x00028A50
	private void NMOGBLDCHBH()
	{
		if (this.EEBLGHNHGID)
		{
			UnityEngine.Object.DestroyImmediate(this.EEBLGHNHGID);
		}
	}

	// Token: 0x06007630 RID: 30256 RVA: 0x0038A41C File Offset: 0x0038861C
	private void MNJBNLCHMNK(RenderTexture MOECMOLDQKL, RenderTexture PNQFLLEDEGG)
	{
		if (!Mathf.Approximately(this.PJMOBJDCOCL, 1292f) && !(this.PNFDDJJKIDO() == null))
		{
			if (Math.Abs(this.PJMOBJDCOCL - this.PNFNJMFMJPK) > 1773f)
			{
				this.PJMOBJDCOCL = Mathf.Clamp01(this.PJMOBJDCOCL);
				this.DNCEIFBHHNH().SetFloat(this.LDKQKGKHCMM, 1779f - this.PJMOBJDCOCL);
				this.KFFIDNIGEIB().SetFloat(this.CIPBCBLOJFM, this.PJMOBJDCOCL);
				this.CQIBJNKQHBH().SetColor(this.MMIJOJLELCH, this.LJLQMONMIKN);
			}
			Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG, this.DNCEIFBHHNH());
			this.PNFNJMFMJPK = this.PJMOBJDCOCL;
			return;
		}
		Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG);
	}

	// Token: 0x06007631 RID: 30257 RVA: 0x0002A898 File Offset: 0x00028A98
	public void CQNEGEICDLK(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		base.StopAllCoroutines();
		base.StartCoroutine(this.MLMKLILEBMM(BPHOCDBPHDP, CPKNEQGKQPQ));
	}

	// Token: 0x06007632 RID: 30258 RVA: 0x0038A4E8 File Offset: 0x003886E8
	private void HCEGKODPDED(RenderTexture MOECMOLDQKL, RenderTexture PNQFLLEDEGG)
	{
		if (!Mathf.Approximately(this.PJMOBJDCOCL, 132f) && !(this.CQIBJNKQHBH() == null))
		{
			if (Math.Abs(this.PJMOBJDCOCL - this.PNFNJMFMJPK) > 251f)
			{
				this.PJMOBJDCOCL = Mathf.Clamp01(this.PJMOBJDCOCL);
				this.NDOQOKGQECQ().SetFloat(this.LDKQKGKHCMM, 74f - this.PJMOBJDCOCL);
				this.KQHLPFNJNND().SetFloat(this.CIPBCBLOJFM, this.PJMOBJDCOCL);
				this.KQHLPFNJNND().SetColor(this.MMIJOJLELCH, this.LJLQMONMIKN);
			}
			Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG, this.KQHLPFNJNND());
			this.PNFNJMFMJPK = this.PJMOBJDCOCL;
			return;
		}
		Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG);
	}

	// Token: 0x06007633 RID: 30259 RVA: 0x0038A1A8 File Offset: 0x003883A8
	private IEnumerator MPQFLFFNIBH(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		pjmobjdcocl = this.PJMOBJDCOCL;
		num = 0f;
		if (num > 1f)
		{
			this.PJMOBJDCOCL = BPHOCDBPHDP;
			yield return null;
		}
		else
		{
			num += Time.deltaTime / CPKNEQGKQPQ;
			this.PJMOBJDCOCL = BDKMFJQPGGE.QEDDMFBJBQO(pjmobjdcocl, BPHOCDBPHDP, num, GMNJJQQPEDB.EaseOut);
			yield return null;
		}
		return 1;
		yield break;
	}

	// Token: 0x06007634 RID: 30260 RVA: 0x0038A5B4 File Offset: 0x003887B4
	private void NIMIQOEGOMD(RenderTexture MOECMOLDQKL, RenderTexture PNQFLLEDEGG)
	{
		if (!Mathf.Approximately(this.PJMOBJDCOCL, 371f) && !(this.NDOQOKGQECQ() == null))
		{
			if (Math.Abs(this.PJMOBJDCOCL - this.PNFNJMFMJPK) > 1885f)
			{
				this.PJMOBJDCOCL = Mathf.Clamp01(this.PJMOBJDCOCL);
				this.KFFIDNIGEIB().SetFloat(this.LDKQKGKHCMM, 1012f - this.PJMOBJDCOCL);
				this.PNFDDJJKIDO().SetFloat(this.CIPBCBLOJFM, this.PJMOBJDCOCL);
				this.FGGNHMPBEPK().SetColor(this.MMIJOJLELCH, this.LJLQMONMIKN);
			}
			Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG, this.PPLIPCEHGNM);
			this.PNFNJMFMJPK = this.PJMOBJDCOCL;
			return;
		}
		Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG);
	}

	// Token: 0x06007635 RID: 30261 RVA: 0x0038A680 File Offset: 0x00388880
	private void NBNKGBLQFLK()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		this.PNFNJMFMJPK = 1720f;
		if (this.LDKQKGKHCMM == 0)
		{
			this.LDKQKGKHCMM = Shader.PropertyToID("#,##0");
		}
		if (this.CIPBCBLOJFM == 0)
		{
			this.CIPBCBLOJFM = Shader.PropertyToID(" must have a 'void' return type.");
		}
		if (this.MMIJOJLELCH == 0)
		{
			this.MMIJOJLELCH = Shader.PropertyToID("berry_13");
		}
	}

	// Token: 0x06007636 RID: 30262 RVA: 0x0038A1A8 File Offset: 0x003883A8
	private IEnumerator LPJCCMEQGHB(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		pjmobjdcocl = this.PJMOBJDCOCL;
		num = 0f;
		if (num > 1f)
		{
			this.PJMOBJDCOCL = BPHOCDBPHDP;
			yield return null;
		}
		else
		{
			num += Time.deltaTime / CPKNEQGKQPQ;
			this.PJMOBJDCOCL = BDKMFJQPGGE.QEDDMFBJBQO(pjmobjdcocl, BPHOCDBPHDP, num, GMNJJQQPEDB.EaseOut);
			yield return null;
		}
		return 1;
		yield break;
	}

	// Token: 0x06007637 RID: 30263 RVA: 0x0002A850 File Offset: 0x00028A50
	private void OnDisable()
	{
		if (this.EEBLGHNHGID)
		{
			UnityEngine.Object.DestroyImmediate(this.EEBLGHNHGID);
		}
	}

	// Token: 0x06007638 RID: 30264 RVA: 0x0002A8AF File Offset: 0x00028AAF
	public void DNKFBJLEDDQ(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		base.StopAllCoroutines();
		base.StartCoroutine(this.KMLPKJFLEBI(BPHOCDBPHDP, CPKNEQGKQPQ));
	}

	// Token: 0x06007639 RID: 30265 RVA: 0x0038A6F0 File Offset: 0x003888F0
	private void MFMKBJBJMEH()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		this.PNFNJMFMJPK = 154f;
		if (this.LDKQKGKHCMM == 0)
		{
			this.LDKQKGKHCMM = Shader.PropertyToID("slots(");
		}
		if (this.CIPBCBLOJFM == 0)
		{
			this.CIPBCBLOJFM = Shader.PropertyToID("Effort Values[FFFF00] (");
		}
		if (this.MMIJOJLELCH == 0)
		{
			this.MMIJOJLELCH = Shader.PropertyToID("[ff6666]");
		}
	}

	// Token: 0x0600763A RID: 30266 RVA: 0x0002A850 File Offset: 0x00028A50
	private void IHENKHEBCNE()
	{
		if (this.EEBLGHNHGID)
		{
			UnityEngine.Object.DestroyImmediate(this.EEBLGHNHGID);
		}
	}

	// Token: 0x0600763B RID: 30267 RVA: 0x0038A760 File Offset: 0x00388960
	private void LLHFQDIMENM(RenderTexture MOECMOLDQKL, RenderTexture PNQFLLEDEGG)
	{
		if (!Mathf.Approximately(this.PJMOBJDCOCL, 61f) && !(this.EGPEBNDHEBO() == null))
		{
			if (Math.Abs(this.PJMOBJDCOCL - this.PNFNJMFMJPK) > 407f)
			{
				this.PJMOBJDCOCL = Mathf.Clamp01(this.PJMOBJDCOCL);
				this.KFFIDNIGEIB().SetFloat(this.LDKQKGKHCMM, 271f - this.PJMOBJDCOCL);
				this.DNCEIFBHHNH().SetFloat(this.CIPBCBLOJFM, this.PJMOBJDCOCL);
				this.KBQGBBBELMQ().SetColor(this.MMIJOJLELCH, this.LJLQMONMIKN);
			}
			Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG, this.PPLIPCEHGNM);
			this.PNFNJMFMJPK = this.PJMOBJDCOCL;
			return;
		}
		Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG);
	}

	// Token: 0x0600763C RID: 30268 RVA: 0x0038A1A8 File Offset: 0x003883A8
	private IEnumerator JMLMMPQECQK(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		pjmobjdcocl = this.PJMOBJDCOCL;
		num = 0f;
		if (num > 1f)
		{
			this.PJMOBJDCOCL = BPHOCDBPHDP;
			yield return null;
		}
		else
		{
			num += Time.deltaTime / CPKNEQGKQPQ;
			this.PJMOBJDCOCL = BDKMFJQPGGE.QEDDMFBJBQO(pjmobjdcocl, BPHOCDBPHDP, num, GMNJJQQPEDB.EaseOut);
			yield return null;
		}
		return 1;
		yield break;
	}

	// Token: 0x0600763D RID: 30269 RVA: 0x0002A8C6 File Offset: 0x00028AC6
	public void OCCDFHENCLG(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		base.StopAllCoroutines();
		base.StartCoroutine(this.ODMCCBLQOBB(BPHOCDBPHDP, CPKNEQGKQPQ));
	}

	// Token: 0x0600763E RID: 30270 RVA: 0x0002A8C6 File Offset: 0x00028AC6
	public void CMNIBNPQMKH(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		base.StopAllCoroutines();
		base.StartCoroutine(this.ODMCCBLQOBB(BPHOCDBPHDP, CPKNEQGKQPQ));
	}

	// Token: 0x0600763F RID: 30271 RVA: 0x0038A1A8 File Offset: 0x003883A8
	private IEnumerator QLHIECGPQPJ(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		pjmobjdcocl = this.PJMOBJDCOCL;
		num = 0f;
		if (num > 1f)
		{
			this.PJMOBJDCOCL = BPHOCDBPHDP;
			yield return null;
		}
		else
		{
			num += Time.deltaTime / CPKNEQGKQPQ;
			this.PJMOBJDCOCL = BDKMFJQPGGE.QEDDMFBJBQO(pjmobjdcocl, BPHOCDBPHDP, num, GMNJJQQPEDB.EaseOut);
			yield return null;
		}
		return 1;
		yield break;
	}

	// Token: 0x06007640 RID: 30272 RVA: 0x0038A1A8 File Offset: 0x003883A8
	private IEnumerator HNHKCJLOBGM(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		pjmobjdcocl = this.PJMOBJDCOCL;
		num = 0f;
		if (num > 1f)
		{
			this.PJMOBJDCOCL = BPHOCDBPHDP;
			yield return null;
		}
		else
		{
			num += Time.deltaTime / CPKNEQGKQPQ;
			this.PJMOBJDCOCL = BDKMFJQPGGE.QEDDMFBJBQO(pjmobjdcocl, BPHOCDBPHDP, num, GMNJJQQPEDB.EaseOut);
			yield return null;
		}
		return 1;
		yield break;
	}

	// Token: 0x06007641 RID: 30273 RVA: 0x0002A8C6 File Offset: 0x00028AC6
	public void NKGFHLMMLFH(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		base.StopAllCoroutines();
		base.StartCoroutine(this.ODMCCBLQOBB(BPHOCDBPHDP, CPKNEQGKQPQ));
	}

	// Token: 0x17000413 RID: 1043
	// (get) Token: 0x06007642 RID: 30274 RVA: 0x0038A82C File Offset: 0x00388A2C
	private Material PPLIPCEHGNM
	{
		get
		{
			if (this.EEBLGHNHGID != null)
			{
				return this.EEBLGHNHGID;
			}
			this.EEBLGHNHGID = new Material(Shader.Find("Hidden/ProCamera2D/Letterbox"))
			{
				hideFlags = HideFlags.HideAndDontSave
			};
			return this.EEBLGHNHGID;
		}
	}

	// Token: 0x06007643 RID: 30275 RVA: 0x0002A8DD File Offset: 0x00028ADD
	public void CGGBMOJDLNH(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		base.StopAllCoroutines();
		base.StartCoroutine(this.OKDNMNJBDMQ(BPHOCDBPHDP, CPKNEQGKQPQ));
	}

	// Token: 0x06007644 RID: 30276 RVA: 0x0038A874 File Offset: 0x00388A74
	private void KKEDQGHBNHO()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		this.PNFNJMFMJPK = 181f;
		if (this.LDKQKGKHCMM == 0)
		{
			this.LDKQKGKHCMM = Shader.PropertyToID("It created a bizarre area in which Pokemon's held items lose their effects!\r\n");
		}
		if (this.CIPBCBLOJFM == 0)
		{
			this.CIPBCBLOJFM = Shader.PropertyToID("icebody");
		}
		if (this.MMIJOJLELCH == 0)
		{
			this.MMIJOJLELCH = Shader.PropertyToID("< 1 minute");
		}
	}

	// Token: 0x06007645 RID: 30277 RVA: 0x0038A8E4 File Offset: 0x00388AE4
	private void GJPIGQBMEGC(RenderTexture MOECMOLDQKL, RenderTexture PNQFLLEDEGG)
	{
		if (!Mathf.Approximately(this.PJMOBJDCOCL, 1545f) && !(this.PPLIPCEHGNM == null))
		{
			if (Math.Abs(this.PJMOBJDCOCL - this.PNFNJMFMJPK) > 1490f)
			{
				this.PJMOBJDCOCL = Mathf.Clamp01(this.PJMOBJDCOCL);
				this.KBQGBBBELMQ().SetFloat(this.LDKQKGKHCMM, 793f - this.PJMOBJDCOCL);
				this.DQLNEPDLDNG().SetFloat(this.CIPBCBLOJFM, this.PJMOBJDCOCL);
				this.PNFDDJJKIDO().SetColor(this.MMIJOJLELCH, this.LJLQMONMIKN);
			}
			Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG, this.FGGNHMPBEPK());
			this.PNFNJMFMJPK = this.PJMOBJDCOCL;
			return;
		}
		Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG);
	}

	// Token: 0x06007646 RID: 30278 RVA: 0x0038A9B0 File Offset: 0x00388BB0
	private void NHQJQDHJMIO()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		this.PNFNJMFMJPK = 229f;
		if (this.LDKQKGKHCMM == 0)
		{
			this.LDKQKGKHCMM = Shader.PropertyToID("Doubles the Pokémon's weight.");
		}
		if (this.CIPBCBLOJFM == 0)
		{
			this.CIPBCBLOJFM = Shader.PropertyToID("General");
		}
		if (this.MMIJOJLELCH == 0)
		{
			this.MMIJOJLELCH = Shader.PropertyToID("cant");
		}
	}

	// Token: 0x06007647 RID: 30279 RVA: 0x0038AA20 File Offset: 0x00388C20
	private void NEBJBQOMHDI()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		this.PNFNJMFMJPK = 859f;
		if (this.LDKQKGKHCMM == 0)
		{
			this.LDKQKGKHCMM = Shader.PropertyToID("13");
		}
		if (this.CIPBCBLOJFM == 0)
		{
			this.CIPBCBLOJFM = Shader.PropertyToID("game object Game Manager not found");
		}
		if (this.MMIJOJLELCH == 0)
		{
			this.MMIJOJLELCH = Shader.PropertyToID("e");
		}
	}

	// Token: 0x06007648 RID: 30280 RVA: 0x0038AA90 File Offset: 0x00388C90
	private void NLHGFQHJODK()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		this.PNFNJMFMJPK = 1494f;
		if (this.LDKQKGKHCMM == 0)
		{
			this.LDKQKGKHCMM = Shader.PropertyToID("'s ");
		}
		if (this.CIPBCBLOJFM == 0)
		{
			this.CIPBCBLOJFM = Shader.PropertyToID(" protected itself!\r\n");
		}
		if (this.MMIJOJLELCH == 0)
		{
			this.MMIJOJLELCH = Shader.PropertyToID("[ff4949]");
		}
	}

	// Token: 0x06007649 RID: 30281 RVA: 0x0038AB00 File Offset: 0x00388D00
	private Material FGGNHMPBEPK()
	{
		if (this.EEBLGHNHGID != null)
		{
			return this.EEBLGHNHGID;
		}
		this.EEBLGHNHGID = new Material(Shader.Find("[FF8F00]"))
		{
			hideFlags = (HideFlags)(-108)
		};
		return this.EEBLGHNHGID;
	}

	// Token: 0x0600764A RID: 30282 RVA: 0x0038AB48 File Offset: 0x00388D48
	private void QEHBCMGNNKK(RenderTexture MOECMOLDQKL, RenderTexture PNQFLLEDEGG)
	{
		if (!Mathf.Approximately(this.PJMOBJDCOCL, 1291f) && !(this.PPLIPCEHGNM == null))
		{
			if (Math.Abs(this.PJMOBJDCOCL - this.PNFNJMFMJPK) > 1196f)
			{
				this.PJMOBJDCOCL = Mathf.Clamp01(this.PJMOBJDCOCL);
				this.EGPEBNDHEBO().SetFloat(this.LDKQKGKHCMM, 582f - this.PJMOBJDCOCL);
				this.KQHLPFNJNND().SetFloat(this.CIPBCBLOJFM, this.PJMOBJDCOCL);
				this.FGGNHMPBEPK().SetColor(this.MMIJOJLELCH, this.LJLQMONMIKN);
			}
			Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG, this.DQLNEPDLDNG());
			this.PNFNJMFMJPK = this.PJMOBJDCOCL;
			return;
		}
		Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG);
	}

	// Token: 0x0600764B RID: 30283 RVA: 0x0038AC14 File Offset: 0x00388E14
	private Material GOQMQFJIJCN()
	{
		if (this.EEBLGHNHGID != null)
		{
			return this.EEBLGHNHGID;
		}
		this.EEBLGHNHGID = new Material(Shader.Find("door_3"))
		{
			hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset)
		};
		return this.EEBLGHNHGID;
	}

	// Token: 0x0600764C RID: 30284 RVA: 0x0038AC5C File Offset: 0x00388E5C
	private void HNPKPINGJID()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		this.PNFNJMFMJPK = 1760f;
		if (this.LDKQKGKHCMM == 0)
		{
			this.LDKQKGKHCMM = Shader.PropertyToID("par");
		}
		if (this.CIPBCBLOJFM == 0)
		{
			this.CIPBCBLOJFM = Shader.PropertyToID("MSGBOX - Confirm EVs");
		}
		if (this.MMIJOJLELCH == 0)
		{
			this.MMIJOJLELCH = Shader.PropertyToID("Blank");
		}
	}

	// Token: 0x0600764D RID: 30285 RVA: 0x0038ACCC File Offset: 0x00388ECC
	private Material NDOQOKGQECQ()
	{
		if (this.EEBLGHNHGID != null)
		{
			return this.EEBLGHNHGID;
		}
		this.EEBLGHNHGID = new Material(Shader.Find("0"))
		{
			hideFlags = (HideFlags)(-85)
		};
		return this.EEBLGHNHGID;
	}

	// Token: 0x0600764E RID: 30286 RVA: 0x0038AD14 File Offset: 0x00388F14
	private void OnEnable()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		this.PNFNJMFMJPK = float.MaxValue;
		if (this.LDKQKGKHCMM == 0)
		{
			this.LDKQKGKHCMM = Shader.PropertyToID("_Top");
		}
		if (this.CIPBCBLOJFM == 0)
		{
			this.CIPBCBLOJFM = Shader.PropertyToID("_Bottom");
		}
		if (this.MMIJOJLELCH == 0)
		{
			this.MMIJOJLELCH = Shader.PropertyToID("_Color");
		}
	}

	// Token: 0x0600764F RID: 30287 RVA: 0x0002A850 File Offset: 0x00028A50
	private void NNBNJQECJBE()
	{
		if (this.EEBLGHNHGID)
		{
			UnityEngine.Object.DestroyImmediate(this.EEBLGHNHGID);
		}
	}

	// Token: 0x06007650 RID: 30288 RVA: 0x0038AD84 File Offset: 0x00388F84
	private Material KQHLPFNJNND()
	{
		if (this.EEBLGHNHGID != null)
		{
			return this.EEBLGHNHGID;
		}
		this.EEBLGHNHGID = new Material(Shader.Find("steadfast"))
		{
			hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild)
		};
		return this.EEBLGHNHGID;
	}

	// Token: 0x06007651 RID: 30289 RVA: 0x0002A850 File Offset: 0x00028A50
	private void MQJJBOQPPGN()
	{
		if (this.EEBLGHNHGID)
		{
			UnityEngine.Object.DestroyImmediate(this.EEBLGHNHGID);
		}
	}

	// Token: 0x06007652 RID: 30290 RVA: 0x0038ADCC File Offset: 0x00388FCC
	private void PHEMLIPBHOJ()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		this.PNFNJMFMJPK = 390f;
		if (this.LDKQKGKHCMM == 0)
		{
			this.LDKQKGKHCMM = Shader.PropertyToID("Guild");
		}
		if (this.CIPBCBLOJFM == 0)
		{
			this.CIPBCBLOJFM = Shader.PropertyToID("CombinersColorScale");
		}
		if (this.MMIJOJLELCH == 0)
		{
			this.MMIJOJLELCH = Shader.PropertyToID("Super Repel");
		}
	}

	// Token: 0x06007654 RID: 30292 RVA: 0x0038AE3C File Offset: 0x0038903C
	private void BIQLBDMMDFK()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		this.PNFNJMFMJPK = 704f;
		if (this.LDKQKGKHCMM == 0)
		{
			this.LDKQKGKHCMM = Shader.PropertyToID("Failed to evolve!");
		}
		if (this.CIPBCBLOJFM == 0)
		{
			this.CIPBCBLOJFM = Shader.PropertyToID("Assets/AssetBundles/Sprites/");
		}
		if (this.MMIJOJLELCH == 0)
		{
			this.MMIJOJLELCH = Shader.PropertyToID("DirY");
		}
	}

	// Token: 0x06007655 RID: 30293 RVA: 0x0038AEAC File Offset: 0x003890AC
	private void QHHEJOMINDE()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		this.PNFNJMFMJPK = 1130f;
		if (this.LDKQKGKHCMM == 0)
		{
			this.LDKQKGKHCMM = Shader.PropertyToID("waterpledge");
		}
		if (this.CIPBCBLOJFM == 0)
		{
			this.CIPBCBLOJFM = Shader.PropertyToID("balloon");
		}
		if (this.MMIJOJLELCH == 0)
		{
			this.MMIJOJLELCH = Shader.PropertyToID("powder");
		}
	}

	// Token: 0x06007656 RID: 30294 RVA: 0x0038AF1C File Offset: 0x0038911C
	private void KBNILQHBQCF(RenderTexture MOECMOLDQKL, RenderTexture PNQFLLEDEGG)
	{
		if (!Mathf.Approximately(this.PJMOBJDCOCL, 528f) && !(this.PNFDDJJKIDO() == null))
		{
			if (Math.Abs(this.PJMOBJDCOCL - this.PNFNJMFMJPK) > 676f)
			{
				this.PJMOBJDCOCL = Mathf.Clamp01(this.PJMOBJDCOCL);
				this.EGPEBNDHEBO().SetFloat(this.LDKQKGKHCMM, 1406f - this.PJMOBJDCOCL);
				this.EGPEBNDHEBO().SetFloat(this.CIPBCBLOJFM, this.PJMOBJDCOCL);
				this.NDOQOKGQECQ().SetColor(this.MMIJOJLELCH, this.LJLQMONMIKN);
			}
			Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG, this.PPLIPCEHGNM);
			this.PNFNJMFMJPK = this.PJMOBJDCOCL;
			return;
		}
		Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG);
	}

	// Token: 0x06007657 RID: 30295 RVA: 0x0002A907 File Offset: 0x00028B07
	public void FCKFIKJFDDQ(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		base.StopAllCoroutines();
		base.StartCoroutine(this.LKDDHLBHQJC(BPHOCDBPHDP, CPKNEQGKQPQ));
	}

	// Token: 0x06007658 RID: 30296 RVA: 0x0038AFE8 File Offset: 0x003891E8
	private void GQICEFDQJNK(RenderTexture MOECMOLDQKL, RenderTexture PNQFLLEDEGG)
	{
		if (!Mathf.Approximately(this.PJMOBJDCOCL, 1114f) && !(this.PNFDDJJKIDO() == null))
		{
			if (Math.Abs(this.PJMOBJDCOCL - this.PNFNJMFMJPK) > 589f)
			{
				this.PJMOBJDCOCL = Mathf.Clamp01(this.PJMOBJDCOCL);
				this.PNFDDJJKIDO().SetFloat(this.LDKQKGKHCMM, 1877f - this.PJMOBJDCOCL);
				this.DNCEIFBHHNH().SetFloat(this.CIPBCBLOJFM, this.PJMOBJDCOCL);
				this.PNFDDJJKIDO().SetColor(this.MMIJOJLELCH, this.LJLQMONMIKN);
			}
			Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG, this.PPLIPCEHGNM);
			this.PNFNJMFMJPK = this.PJMOBJDCOCL;
			return;
		}
		Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG);
	}

	// Token: 0x06007659 RID: 30297 RVA: 0x0038B0B4 File Offset: 0x003892B4
	private void JKQQMLBPJGD(RenderTexture MOECMOLDQKL, RenderTexture PNQFLLEDEGG)
	{
		if (!Mathf.Approximately(this.PJMOBJDCOCL, 127f) && !(this.PPLIPCEHGNM == null))
		{
			if (Math.Abs(this.PJMOBJDCOCL - this.PNFNJMFMJPK) > 1713f)
			{
				this.PJMOBJDCOCL = Mathf.Clamp01(this.PJMOBJDCOCL);
				this.KQHLPFNJNND().SetFloat(this.LDKQKGKHCMM, 1001f - this.PJMOBJDCOCL);
				this.DNCEIFBHHNH().SetFloat(this.CIPBCBLOJFM, this.PJMOBJDCOCL);
				this.DNCEIFBHHNH().SetColor(this.MMIJOJLELCH, this.LJLQMONMIKN);
			}
			Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG, this.KBQGBBBELMQ());
			this.PNFNJMFMJPK = this.PJMOBJDCOCL;
			return;
		}
		Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG);
	}

	// Token: 0x0600765A RID: 30298 RVA: 0x0038B180 File Offset: 0x00389380
	private void OnRenderImage(RenderTexture MOECMOLDQKL, RenderTexture PNQFLLEDEGG)
	{
		if (!Mathf.Approximately(this.PJMOBJDCOCL, 0f) && !(this.PPLIPCEHGNM == null))
		{
			if (Math.Abs(this.PJMOBJDCOCL - this.PNFNJMFMJPK) > 0.0001f)
			{
				this.PJMOBJDCOCL = Mathf.Clamp01(this.PJMOBJDCOCL);
				this.PPLIPCEHGNM.SetFloat(this.LDKQKGKHCMM, 1f - this.PJMOBJDCOCL);
				this.PPLIPCEHGNM.SetFloat(this.CIPBCBLOJFM, this.PJMOBJDCOCL);
				this.PPLIPCEHGNM.SetColor(this.MMIJOJLELCH, this.LJLQMONMIKN);
			}
			Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG, this.PPLIPCEHGNM);
			this.PNFNJMFMJPK = this.PJMOBJDCOCL;
			return;
		}
		Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG);
	}

	// Token: 0x0600765B RID: 30299 RVA: 0x0038B24C File Offset: 0x0038944C
	private Material NFHDHOMPNQN()
	{
		if (this.EEBLGHNHGID != null)
		{
			return this.EEBLGHNHGID;
		}
		this.EEBLGHNHGID = new Material(Shader.Find(" [M]"))
		{
			hideFlags = (HideFlags)125
		};
		return this.EEBLGHNHGID;
	}

	// Token: 0x0600765C RID: 30300 RVA: 0x0038B294 File Offset: 0x00389494
	private Material PNFDDJJKIDO()
	{
		if (this.EEBLGHNHGID != null)
		{
			return this.EEBLGHNHGID;
		}
		this.EEBLGHNHGID = new Material(Shader.Find("liquidooze"))
		{
			hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild)
		};
		return this.EEBLGHNHGID;
	}

	// Token: 0x0600765D RID: 30301 RVA: 0x0002A91E File Offset: 0x00028B1E
	public void BINFHDMLBQM(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		base.StopAllCoroutines();
		base.StartCoroutine(this.QLHIECGPQPJ(BPHOCDBPHDP, CPKNEQGKQPQ));
	}

	// Token: 0x0600765E RID: 30302 RVA: 0x0038B2DC File Offset: 0x003894DC
	private void GEIDOFMHECG()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		this.PNFNJMFMJPK = 291f;
		if (this.LDKQKGKHCMM == 0)
		{
			this.LDKQKGKHCMM = Shader.PropertyToID("StopRow1");
		}
		if (this.CIPBCBLOJFM == 0)
		{
			this.CIPBCBLOJFM = Shader.PropertyToID("\nMorning");
		}
		if (this.MMIJOJLELCH == 0)
		{
			this.MMIJOJLELCH = Shader.PropertyToID("Player Fly Mount");
		}
	}

	// Token: 0x0600765F RID: 30303 RVA: 0x0002A850 File Offset: 0x00028A50
	private void EIICFMBEMFF()
	{
		if (this.EEBLGHNHGID)
		{
			UnityEngine.Object.DestroyImmediate(this.EEBLGHNHGID);
		}
	}

	// Token: 0x06007660 RID: 30304 RVA: 0x0038A1A8 File Offset: 0x003883A8
	private IEnumerator ODMCCBLQOBB(float BPHOCDBPHDP, float CPKNEQGKQPQ)
	{
		pjmobjdcocl = this.PJMOBJDCOCL;
		num = 0f;
		if (num > 1f)
		{
			this.PJMOBJDCOCL = BPHOCDBPHDP;
			yield return null;
		}
		else
		{
			num += Time.deltaTime / CPKNEQGKQPQ;
			this.PJMOBJDCOCL = BDKMFJQPGGE.QEDDMFBJBQO(pjmobjdcocl, BPHOCDBPHDP, num, GMNJJQQPEDB.EaseOut);
			yield return null;
		}
		return 1;
		yield break;
	}

	// Token: 0x06007661 RID: 30305 RVA: 0x0038B34C File Offset: 0x0038954C
	private void OFLEOHNLPCB()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		this.PNFNJMFMJPK = 186f;
		if (this.LDKQKGKHCMM == 0)
		{
			this.LDKQKGKHCMM = Shader.PropertyToID("#,##0");
		}
		if (this.CIPBCBLOJFM == 0)
		{
			this.CIPBCBLOJFM = Shader.PropertyToID("4_");
		}
		if (this.MMIJOJLELCH == 0)
		{
			this.MMIJOJLELCH = Shader.PropertyToID("'s [ffff00]");
		}
	}

	// Token: 0x06007662 RID: 30306 RVA: 0x0038B3BC File Offset: 0x003895BC
	private void DHKFKFHEOOM(RenderTexture MOECMOLDQKL, RenderTexture PNQFLLEDEGG)
	{
		if (!Mathf.Approximately(this.PJMOBJDCOCL, 558f) && !(this.DQLNEPDLDNG() == null))
		{
			if (Math.Abs(this.PJMOBJDCOCL - this.PNFNJMFMJPK) > 930f)
			{
				this.PJMOBJDCOCL = Mathf.Clamp01(this.PJMOBJDCOCL);
				this.DNCEIFBHHNH().SetFloat(this.LDKQKGKHCMM, 134f - this.PJMOBJDCOCL);
				this.PNFDDJJKIDO().SetFloat(this.CIPBCBLOJFM, this.PJMOBJDCOCL);
				this.GOQMQFJIJCN().SetColor(this.MMIJOJLELCH, this.LJLQMONMIKN);
			}
			Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG, this.KFFIDNIGEIB());
			this.PNFNJMFMJPK = this.PJMOBJDCOCL;
			return;
		}
		Graphics.Blit(MOECMOLDQKL, PNQFLLEDEGG);
	}

	// Token: 0x0400199B RID: 6555
	[Range(0f, 0.5f)]
	public float PJMOBJDCOCL;

	// Token: 0x0400199C RID: 6556
	public Color LJLQMONMIKN;

	// Token: 0x0400199D RID: 6557
	private Material EEBLGHNHGID;

	// Token: 0x0400199E RID: 6558
	private int LDKQKGKHCMM;

	// Token: 0x0400199F RID: 6559
	private int CIPBCBLOJFM;

	// Token: 0x040019A0 RID: 6560
	private int MMIJOJLELCH;

	// Token: 0x040019A1 RID: 6561
	private float PNFNJMFMJPK = float.MaxValue;
}
