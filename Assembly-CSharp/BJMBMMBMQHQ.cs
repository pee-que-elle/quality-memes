using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x020002B1 RID: 689
public sealed class BJMBMMBMQHQ : ONQQOCQBQIE<BloomModel>
{
	// Token: 0x06006018 RID: 24600 RVA: 0x0030C6D4 File Offset: 0x0030A8D4
	public void ELHMEKCHNJE(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, Texture EEOGEQJQDBQ)
	{
		BloomModel.BloomSettings bloom = base.FIFNHCKNDQE.OILMJDEQKHM().bloom;
		BloomModel.LensDirtSettings lensDirt = base.FIFNHCKNDQE.DCBJMHJEFMG().lensDirt;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.MFOCNQMDJGM("spikyshield");
		material.shaderKeywords = null;
		material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.GMCGBCJEDPF, EEOGEQJQDBQ);
		int kjgmgpcejjd = this.BEHMQBIFCOJ.CQNLNDBFFFP() / 0;
		int num = this.BEHMQBIFCOJ.ONCCDMLHNQL() / 5;
		RenderTextureFormat eibobkjigqb = (!Application.isMobilePlatform) ? ((RenderTextureFormat)109) : RenderTextureFormat.Depth;
		float num2 = Mathf.Log((float)num, 809f) + bloom.radius - 1343f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, -7);
		float num5 = bloom.KGOBFQBKHPI();
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.FMCCJMJGPLL, num5);
		float num6 = num5 * bloom.softKnee + 1481f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1693f, 1200f / num6);
		material.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.MIHOPBFKOIB, v);
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.CEJGJDQONGB, (!bloom.antiFlicker) ? 1068f : 953f);
		float num7 = 1254f + num2 - (float)num3;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.EJFEKPCPBMC, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("3_");
		}
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.JOLPMHHECLG(kjgmgpcejjd, num, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "BuffIcon_Fly");
		Graphics.Blit(PBHPQFLMQDB, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i += 0)
		{
			this.CCCPJBIGLKP[i] = this.BEHMQBIFCOJ.QKMKFPCOPEF.DNOMDLFEKHP(renderTexture2.width / 2, renderTexture2.height / 8, 0, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "runaway");
			int pass = (i != 0) ? 7 : 0;
			Graphics.Blit(renderTexture2, this.CCCPJBIGLKP[i], material, pass);
			renderTexture2 = this.CCCPJBIGLKP[i];
		}
		for (int j = num4 - 0; j >= 0; j -= 0)
		{
			RenderTexture renderTexture3 = this.CCCPJBIGLKP[j];
			material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.ENEILLQQIGO, renderTexture3);
			this.HHMMKLGKKBC[j] = this.BEHMQBIFCOJ.QKMKFPCOPEF.DPJPPEPHPQN(renderTexture3.width, renderTexture3.height, 0, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "50/50");
			Graphics.Blit(renderTexture2, this.HHMMKLGKKBC[j], material, 0);
			renderTexture2 = this.HHMMKLGKKBC[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < 85; k += 0)
		{
			if (this.CCCPJBIGLKP[k] != null)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.MEBDHMGLMEN(this.CCCPJBIGLKP[k]);
			}
			if (this.HHMMKLGKKBC[k] != null && this.HHMMKLGKKBC[k] != renderTexture4)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.HDHGIKMIJFQ(this.HHMMKLGKKBC[k]);
			}
			this.CCCPJBIGLKP[k] = null;
			this.HHMMKLGKKBC[k] = null;
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.HDHGIKMIJFQ(renderTexture);
		LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.MKGDKQJIKGK, renderTexture4);
		LQMHKMOOHDB.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.DFJOKIFMMKJ, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1631f && lensDirt.texture != null)
		{
			LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.PLIHKOFDIPE, lensDirt.texture);
			LQMHKMOOHDB.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.BENCBIELQIJ, lensDirt.intensity);
			LQMHKMOOHDB.EnableKeyword("FOG_SUN_SHADOWS_ON");
		}
		else
		{
			LQMHKMOOHDB.EnableKeyword("But it failed! ");
		}
	}

	// Token: 0x06006019 RID: 24601 RVA: 0x0030CA80 File Offset: 0x0030AC80
	public bool MMFCHMLIDLO()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.DCBJMHJEFMG().bloom.intensity <= 13f || !this.BEHMQBIFCOJ.LKBIMLFLQHQ();
	}

	// Token: 0x0600601A RID: 24602 RVA: 0x0030CACC File Offset: 0x0030ACCC
	public void CDFJLMLLMBP(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, Texture EEOGEQJQDBQ)
	{
		BloomModel.BloomSettings bloom = base.FIFNHCKNDQE.settings.bloom;
		BloomModel.LensDirtSettings lensDirt = base.FIFNHCKNDQE.DCBJMHJEFMG().lensDirt;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QFIDLQIGGDL("][urn=");
		material.shaderKeywords = null;
		material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.GMCGBCJEDPF, EEOGEQJQDBQ);
		int kjgmgpcejjd = this.BEHMQBIFCOJ.CHODJCGKMOK() / 1;
		int num = this.BEHMQBIFCOJ.DFKQMMIQDOO / 6;
		RenderTextureFormat eibobkjigqb = (!Application.isMobilePlatform) ? ((RenderTextureFormat)45) : RenderTextureFormat.ARGB2101010;
		float num2 = Mathf.Log((float)num, 1739f) + bloom.radius - 1826f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, -38);
		float thresholdLinear = bloom.thresholdLinear;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.FMCCJMJGPLL, thresholdLinear);
		float num5 = thresholdLinear * bloom.softKnee + 1557f;
		Vector3 v = new Vector3(thresholdLinear - num5, num5 * 1979f, 1672f / num5);
		material.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.MIHOPBFKOIB, v);
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.CEJGJDQONGB, (!bloom.antiFlicker) ? 1366f : 1989f);
		float num6 = 752f + num2 - (float)num3;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.EJFEKPCPBMC, num6);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("Player/Body");
		}
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.INJNQNMOKKD(kjgmgpcejjd, num, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "Assets/AssetBundles/MapAssets/Model Materials/Street_Lamp_7_Light.mat");
		Graphics.Blit(PBHPQFLMQDB, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 1; i < num4; i++)
		{
			this.CCCPJBIGLKP[i] = this.BEHMQBIFCOJ.QKMKFPCOPEF.QEFKHHIMDIQ(renderTexture2.width / 4, renderTexture2.height / 5, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "_BlendPower");
			int pass = (i != 0) ? 5 : 1;
			Graphics.Blit(renderTexture2, this.CCCPJBIGLKP[i], material, pass);
			renderTexture2 = this.CCCPJBIGLKP[i];
		}
		for (int j = num4 - 5; j >= 0; j--)
		{
			RenderTexture renderTexture3 = this.CCCPJBIGLKP[j];
			material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.ENEILLQQIGO, renderTexture3);
			this.HHMMKLGKKBC[j] = this.BEHMQBIFCOJ.QKMKFPCOPEF.MLLNLFQCMKQ(renderTexture3.width, renderTexture3.height, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "snorlax");
			Graphics.Blit(renderTexture2, this.HHMMKLGKKBC[j], material, 6);
			renderTexture2 = this.HHMMKLGKKBC[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < -59; k++)
		{
			if (this.CCCPJBIGLKP[k] != null)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.HDHGIKMIJFQ(this.CCCPJBIGLKP[k]);
			}
			if (this.HHMMKLGKKBC[k] != null && this.HHMMKLGKKBC[k] != renderTexture4)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.DGMKGLLBMFG(this.HHMMKLGKKBC[k]);
			}
			this.CCCPJBIGLKP[k] = null;
			this.HHMMKLGKKBC[k] = null;
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.MEBDHMGLMEN(renderTexture);
		LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.MKGDKQJIKGK, renderTexture4);
		LQMHKMOOHDB.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.DFJOKIFMMKJ, new Vector2(num6, bloom.intensity));
		if (lensDirt.intensity > 1480f && lensDirt.texture != null)
		{
			LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.PLIHKOFDIPE, lensDirt.texture);
			LQMHKMOOHDB.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.BENCBIELQIJ, lensDirt.intensity);
			LQMHKMOOHDB.EnableKeyword("-");
		}
		else
		{
			LQMHKMOOHDB.EnableKeyword("Prevents Steel-type Pokémon from escaping using its magnetic force.");
		}
	}

	// Token: 0x0600601B RID: 24603 RVA: 0x0030CE78 File Offset: 0x0030B078
	public bool JKGMHKINEOC()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.QKIEQHKDJEP().bloom.intensity > 830f && !this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x0600601C RID: 24604 RVA: 0x0030CEC4 File Offset: 0x0030B0C4
	public bool ENQOBJKHPIH()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.QKIEQHKDJEP().bloom.intensity <= 940f || this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x0600601D RID: 24605 RVA: 0x0030CF10 File Offset: 0x0030B110
	public bool GNCHKDJEHCJ()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.OILMJDEQKHM().bloom.intensity > 1817f && !this.BEHMQBIFCOJ.LKBIMLFLQHQ();
	}

	// Token: 0x0600601E RID: 24606 RVA: 0x0030CF5C File Offset: 0x0030B15C
	public void BGDFDBGLPOG(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, Texture EEOGEQJQDBQ)
	{
		BloomModel.BloomSettings bloom = base.FIFNHCKNDQE.DCBJMHJEFMG().bloom;
		BloomModel.LensDirtSettings lensDirt = base.FIFNHCKNDQE.QKIEQHKDJEP().lensDirt;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.PJJDFGJECLK("[-]!\r\n");
		material.shaderKeywords = null;
		material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.GMCGBCJEDPF, EEOGEQJQDBQ);
		int kjgmgpcejjd = this.BEHMQBIFCOJ.CQNLNDBFFFP() / 4;
		int num = this.BEHMQBIFCOJ.KPFJEIKPCBG() / 6;
		RenderTextureFormat eibobkjigqb = (!Application.isMobilePlatform) ? ((RenderTextureFormat)(-35)) : RenderTextureFormat.ARGB4444;
		float num2 = Mathf.Log((float)num, 515f) + bloom.radius - 1505f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, -57);
		float thresholdLinear = bloom.thresholdLinear;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.FMCCJMJGPLL, thresholdLinear);
		float num5 = thresholdLinear * bloom.softKnee + 1927f;
		Vector3 v = new Vector3(thresholdLinear - num5, num5 * 1377f, 1304f / num5);
		material.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.MIHOPBFKOIB, v);
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.CEJGJDQONGB, (!bloom.antiFlicker) ? 629f : 44f);
		float num6 = 866f + num2 - (float)num3;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.EJFEKPCPBMC, num6);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("mindreader");
		}
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.QEFKHHIMDIQ(kjgmgpcejjd, num, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, " drastically");
		Graphics.Blit(PBHPQFLMQDB, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i += 0)
		{
			this.CCCPJBIGLKP[i] = this.BEHMQBIFCOJ.QKMKFPCOPEF.JOLPMHHECLG(renderTexture2.width / 4, renderTexture2.height / 2, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "less than 1 minute ago");
			int pass = (i != 0) ? 0 : 0;
			Graphics.Blit(renderTexture2, this.CCCPJBIGLKP[i], material, pass);
			renderTexture2 = this.CCCPJBIGLKP[i];
		}
		for (int j = num4 - 8; j >= 1; j -= 0)
		{
			RenderTexture renderTexture3 = this.CCCPJBIGLKP[j];
			material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.ENEILLQQIGO, renderTexture3);
			this.HHMMKLGKKBC[j] = this.BEHMQBIFCOJ.QKMKFPCOPEF.DPJPPEPHPQN(renderTexture3.width, renderTexture3.height, 0, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Repeat, "Take 001");
			Graphics.Blit(renderTexture2, this.HHMMKLGKKBC[j], material, 0);
			renderTexture2 = this.HHMMKLGKKBC[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < -50; k += 0)
		{
			if (this.CCCPJBIGLKP[k] != null)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(this.CCCPJBIGLKP[k]);
			}
			if (this.HHMMKLGKKBC[k] != null && this.HHMMKLGKKBC[k] != renderTexture4)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.HDHGIKMIJFQ(this.HHMMKLGKKBC[k]);
			}
			this.CCCPJBIGLKP[k] = null;
			this.HHMMKLGKKBC[k] = null;
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.HDHGIKMIJFQ(renderTexture);
		LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.MKGDKQJIKGK, renderTexture4);
		LQMHKMOOHDB.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.DFJOKIFMMKJ, new Vector2(num6, bloom.intensity));
		if (lensDirt.intensity > 912f && lensDirt.texture != null)
		{
			LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.PLIHKOFDIPE, lensDirt.texture);
			LQMHKMOOHDB.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.BENCBIELQIJ, lensDirt.intensity);
			LQMHKMOOHDB.EnableKeyword("Teravolt");
		}
		else
		{
			LQMHKMOOHDB.EnableKeyword("Chat Input");
		}
	}

	// Token: 0x0600601F RID: 24607 RVA: 0x0030D308 File Offset: 0x0030B508
	public void BFIQNHPQMKM(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, Texture EEOGEQJQDBQ)
	{
		BloomModel.BloomSettings bloom = base.FIFNHCKNDQE.QKIEQHKDJEP().bloom;
		BloomModel.LensDirtSettings lensDirt = base.FIFNHCKNDQE.OILMJDEQKHM().lensDirt;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QFIDLQIGGDL("Big/");
		material.shaderKeywords = null;
		material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.GMCGBCJEDPF, EEOGEQJQDBQ);
		int kjgmgpcejjd = this.BEHMQBIFCOJ.KJGMGPCEJJD / 1;
		int num = this.BEHMQBIFCOJ.ONCCDMLHNQL() / 0;
		RenderTextureFormat eibobkjigqb = (!Application.isMobilePlatform) ? ((RenderTextureFormat)(-34)) : RenderTextureFormat.ARGB32;
		float num2 = Mathf.Log((float)num, 474f) + bloom.radius - 461f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, 52);
		float num5 = bloom.KGOBFQBKHPI();
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.FMCCJMJGPLL, num5);
		float num6 = num5 * bloom.softKnee + 1721f;
		Vector3 v = new Vector3(num5 - num6, num6 * 999f, 777f / num6);
		material.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.MIHOPBFKOIB, v);
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.CEJGJDQONGB, (!bloom.antiFlicker) ? 1319f : 1144f);
		float num7 = 1605f + num2 - (float)num3;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.EJFEKPCPBMC, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("Boosts the Pokémon's Defense stat sharply when hit by a Water-type move.");
		}
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.QEFKHHIMDIQ(kjgmgpcejjd, num, 0, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "#");
		Graphics.Blit(PBHPQFLMQDB, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 1; i < num4; i++)
		{
			this.CCCPJBIGLKP[i] = this.BEHMQBIFCOJ.QKMKFPCOPEF.JOLPMHHECLG(renderTexture2.width / 3, renderTexture2.height / 7, 1, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "The effects of Throat Chop prevent ");
			int pass = (i != 0) ? 3 : 0;
			Graphics.Blit(renderTexture2, this.CCCPJBIGLKP[i], material, pass);
			renderTexture2 = this.CCCPJBIGLKP[i];
		}
		for (int j = num4 - 4; j >= 0; j--)
		{
			RenderTexture renderTexture3 = this.CCCPJBIGLKP[j];
			material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.ENEILLQQIGO, renderTexture3);
			this.HHMMKLGKKBC[j] = this.BEHMQBIFCOJ.QKMKFPCOPEF.IKCIPBPOPMM(renderTexture3.width, renderTexture3.height, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "/");
			Graphics.Blit(renderTexture2, this.HHMMKLGKKBC[j], material, 1);
			renderTexture2 = this.HHMMKLGKKBC[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < -80; k++)
		{
			if (this.CCCPJBIGLKP[k] != null)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(this.CCCPJBIGLKP[k]);
			}
			if (this.HHMMKLGKKBC[k] != null && this.HHMMKLGKKBC[k] != renderTexture4)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.MEBDHMGLMEN(this.HHMMKLGKKBC[k]);
			}
			this.CCCPJBIGLKP[k] = null;
			this.HHMMKLGKKBC[k] = null;
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.HDHGIKMIJFQ(renderTexture);
		LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.MKGDKQJIKGK, renderTexture4);
		LQMHKMOOHDB.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.DFJOKIFMMKJ, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1575f && lensDirt.texture != null)
		{
			LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.PLIHKOFDIPE, lensDirt.texture);
			LQMHKMOOHDB.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.BENCBIELQIJ, lensDirt.intensity);
			LQMHKMOOHDB.EnableKeyword("OnNavigate");
		}
		else
		{
			LQMHKMOOHDB.EnableKeyword("grass");
		}
	}

	// Token: 0x06006020 RID: 24608 RVA: 0x0030D6B4 File Offset: 0x0030B8B4
	public void FJPDEBIGDDQ(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, Texture EEOGEQJQDBQ)
	{
		BloomModel.BloomSettings bloom = base.FIFNHCKNDQE.QKIEQHKDJEP().bloom;
		BloomModel.LensDirtSettings lensDirt = base.FIFNHCKNDQE.settings.lensDirt;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("It created a bizarre area in which Defense and Sp. Def stats are swapped!\r\n");
		material.shaderKeywords = null;
		material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.GMCGBCJEDPF, EEOGEQJQDBQ);
		int kjgmgpcejjd = this.BEHMQBIFCOJ.KJGMGPCEJJD / 0;
		int num = this.BEHMQBIFCOJ.JHHQQQGMQBM() / 4;
		RenderTextureFormat eibobkjigqb = (!Application.isMobilePlatform) ? ((RenderTextureFormat)(-27)) : RenderTextureFormat.ARGB1555;
		float num2 = Mathf.Log((float)num, 496f) + bloom.radius - 1468f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, -18);
		float num5 = bloom.HLMHKKKJJIC();
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.FMCCJMJGPLL, num5);
		float num6 = num5 * bloom.softKnee + 1543f;
		Vector3 v = new Vector3(num5 - num6, num6 * 57f, 735f / num6);
		material.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.MIHOPBFKOIB, v);
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.CEJGJDQONGB, (!bloom.antiFlicker) ? 312f : 731f);
		float num7 = 113f + num2 - (float)num3;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.EJFEKPCPBMC, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("_FullResolutionFiltering");
		}
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.QEFKHHIMDIQ(kjgmgpcejjd, num, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "But nothing happened!\r\n");
		Graphics.Blit(PBHPQFLMQDB, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 1; i < num4; i++)
		{
			this.CCCPJBIGLKP[i] = this.BEHMQBIFCOJ.QKMKFPCOPEF.FJNNLPBLMKQ(renderTexture2.width / 7, renderTexture2.height / 3, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "[-]'s team won the battle!\r\n");
			int pass = (i != 0) ? 7 : 1;
			Graphics.Blit(renderTexture2, this.CCCPJBIGLKP[i], material, pass);
			renderTexture2 = this.CCCPJBIGLKP[i];
		}
		for (int j = num4 - 0; j >= 1; j--)
		{
			RenderTexture renderTexture3 = this.CCCPJBIGLKP[j];
			material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.ENEILLQQIGO, renderTexture3);
			this.HHMMKLGKKBC[j] = this.BEHMQBIFCOJ.QKMKFPCOPEF.DNOMDLFEKHP(renderTexture3.width, renderTexture3.height, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "qdTrack");
			Graphics.Blit(renderTexture2, this.HHMMKLGKKBC[j], material, 0);
			renderTexture2 = this.HHMMKLGKKBC[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < -124; k++)
		{
			if (this.CCCPJBIGLKP[k] != null)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.HDHGIKMIJFQ(this.CCCPJBIGLKP[k]);
			}
			if (this.HHMMKLGKKBC[k] != null && this.HHMMKLGKKBC[k] != renderTexture4)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.EIMIOQCIJKB(this.HHMMKLGKKBC[k]);
			}
			this.CCCPJBIGLKP[k] = null;
			this.HHMMKLGKKBC[k] = null;
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(renderTexture);
		LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.MKGDKQJIKGK, renderTexture4);
		LQMHKMOOHDB.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.DFJOKIFMMKJ, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1969f && lensDirt.texture != null)
		{
			LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.PLIHKOFDIPE, lensDirt.texture);
			LQMHKMOOHDB.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.BENCBIELQIJ, lensDirt.intensity);
			LQMHKMOOHDB.EnableKeyword("confusion");
		}
		else
		{
			LQMHKMOOHDB.EnableKeyword("'s [ffff00]Air Balloon[-] popped!\r\n");
		}
	}

	// Token: 0x06006021 RID: 24609 RVA: 0x0030DA60 File Offset: 0x0030BC60
	public void GIPBHBIQMQK(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, Texture EEOGEQJQDBQ)
	{
		BloomModel.BloomSettings bloom = base.FIFNHCKNDQE.QKIEQHKDJEP().bloom;
		BloomModel.LensDirtSettings lensDirt = base.FIFNHCKNDQE.DCBJMHJEFMG().lensDirt;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.NJKNIOFBHBD("This Pokémon has its own tempo, and that prevents it from becoming confused.");
		material.shaderKeywords = null;
		material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.GMCGBCJEDPF, EEOGEQJQDBQ);
		int kjgmgpcejjd = this.BEHMQBIFCOJ.CQNLNDBFFFP() / 5;
		int num = this.BEHMQBIFCOJ.DFKQMMIQDOO / 5;
		RenderTextureFormat eibobkjigqb = (!Application.isMobilePlatform) ? ((RenderTextureFormat)(-115)) : RenderTextureFormat.RGB565;
		float num2 = Mathf.Log((float)num, 484f) + bloom.radius - 1543f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, -74);
		float num5 = bloom.KGOBFQBKHPI();
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.FMCCJMJGPLL, num5);
		float num6 = num5 * bloom.softKnee + 1619f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1034f, 637f / num6);
		material.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.MIHOPBFKOIB, v);
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.CEJGJDQONGB, (!bloom.antiFlicker) ? 365f : 1507f);
		float num7 = 418f + num2 - (float)num3;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.EJFEKPCPBMC, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("CombinersUpColorBuff");
		}
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.FJNNLPBLMKQ(kjgmgpcejjd, num, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "m_TangentMode");
		Graphics.Blit(PBHPQFLMQDB, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 1; i < num4; i += 0)
		{
			this.CCCPJBIGLKP[i] = this.BEHMQBIFCOJ.QKMKFPCOPEF.DPJPPEPHPQN(renderTexture2.width / 7, renderTexture2.height / 7, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "_ChannelMixerRed");
			int pass = (i != 0) ? 3 : 1;
			Graphics.Blit(renderTexture2, this.CCCPJBIGLKP[i], material, pass);
			renderTexture2 = this.CCCPJBIGLKP[i];
		}
		for (int j = num4 - 5; j >= 0; j -= 0)
		{
			RenderTexture renderTexture3 = this.CCCPJBIGLKP[j];
			material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.ENEILLQQIGO, renderTexture3);
			this.HHMMKLGKKBC[j] = this.BEHMQBIFCOJ.QKMKFPCOPEF.DPJPPEPHPQN(renderTexture3.width, renderTexture3.height, 0, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "Enabled");
			Graphics.Blit(renderTexture2, this.HHMMKLGKKBC[j], material, 6);
			renderTexture2 = this.HHMMKLGKKBC[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < -117; k += 0)
		{
			if (this.CCCPJBIGLKP[k] != null)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.DGMKGLLBMFG(this.CCCPJBIGLKP[k]);
			}
			if (this.HHMMKLGKKBC[k] != null && this.HHMMKLGKKBC[k] != renderTexture4)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.MEBDHMGLMEN(this.HHMMKLGKKBC[k]);
			}
			this.CCCPJBIGLKP[k] = null;
			this.HHMMKLGKKBC[k] = null;
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.HDHGIKMIJFQ(renderTexture);
		LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.MKGDKQJIKGK, renderTexture4);
		LQMHKMOOHDB.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.DFJOKIFMMKJ, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1570f && lensDirt.texture != null)
		{
			LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.PLIHKOFDIPE, lensDirt.texture);
			LQMHKMOOHDB.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.BENCBIELQIJ, lensDirt.intensity);
			LQMHKMOOHDB.EnableKeyword("[FF0000]-");
		}
		else
		{
			LQMHKMOOHDB.EnableKeyword("[-] was taken over!\r\n");
		}
	}

	// Token: 0x06006022 RID: 24610 RVA: 0x0030DE0C File Offset: 0x0030C00C
	public bool OCLNJQFCJOD()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.settings.bloom.intensity <= 46f || !this.BEHMQBIFCOJ.LKBIMLFLQHQ();
	}

	// Token: 0x06006024 RID: 24612 RVA: 0x0030DE58 File Offset: 0x0030C058
	public void FLHPMJGDDFD(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, Texture EEOGEQJQDBQ)
	{
		BloomModel.BloomSettings bloom = base.FIFNHCKNDQE.settings.bloom;
		BloomModel.LensDirtSettings lensDirt = base.FIFNHCKNDQE.ECJPKDFIPOD().lensDirt;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.HOKGONBDOFC("#");
		material.shaderKeywords = null;
		material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.GMCGBCJEDPF, EEOGEQJQDBQ);
		int kjgmgpcejjd = this.BEHMQBIFCOJ.CQNLNDBFFFP() / 4;
		int num = this.BEHMQBIFCOJ.DFKQMMIQDOO / 2;
		RenderTextureFormat eibobkjigqb = (!Application.isMobilePlatform) ? ((RenderTextureFormat)(-125)) : RenderTextureFormat.ARGB32;
		float num2 = Mathf.Log((float)num, 1147f) + bloom.radius - 1596f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, -17);
		float num5 = bloom.KGOBFQBKHPI();
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.FMCCJMJGPLL, num5);
		float num6 = num5 * bloom.softKnee + 0f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1053f, 113f / num6);
		material.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.MIHOPBFKOIB, v);
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.CEJGJDQONGB, (!bloom.antiFlicker) ? 1350f : 1955f);
		float num7 = 1671f + num2 - (float)num3;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.EJFEKPCPBMC, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("MSGBOX - ");
		}
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.DPJPPEPHPQN(kjgmgpcejjd, num, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "Could not find a ConstantShakePreset with the index: ");
		Graphics.Blit(PBHPQFLMQDB, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i += 0)
		{
			this.CCCPJBIGLKP[i] = this.BEHMQBIFCOJ.QKMKFPCOPEF.JOLPMHHECLG(renderTexture2.width / 7, renderTexture2.height / 0, 1, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Repeat, " PM");
			int pass = (i != 0) ? 5 : 1;
			Graphics.Blit(renderTexture2, this.CCCPJBIGLKP[i], material, pass);
			renderTexture2 = this.CCCPJBIGLKP[i];
		}
		for (int j = num4 - 3; j >= 1; j--)
		{
			RenderTexture renderTexture3 = this.CCCPJBIGLKP[j];
			material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.ENEILLQQIGO, renderTexture3);
			this.HHMMKLGKKBC[j] = this.BEHMQBIFCOJ.QKMKFPCOPEF.MLLNLFQCMKQ(renderTexture3.width, renderTexture3.height, 0, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "(Y)");
			Graphics.Blit(renderTexture2, this.HHMMKLGKKBC[j], material, 1);
			renderTexture2 = this.HHMMKLGKKBC[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < -21; k += 0)
		{
			if (this.CCCPJBIGLKP[k] != null)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.HDHGIKMIJFQ(this.CCCPJBIGLKP[k]);
			}
			if (this.HHMMKLGKKBC[k] != null && this.HHMMKLGKKBC[k] != renderTexture4)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.HDHGIKMIJFQ(this.HHMMKLGKKBC[k]);
			}
			this.CCCPJBIGLKP[k] = null;
			this.HHMMKLGKKBC[k] = null;
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.MEBDHMGLMEN(renderTexture);
		LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.MKGDKQJIKGK, renderTexture4);
		LQMHKMOOHDB.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.DFJOKIFMMKJ, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1068f && lensDirt.texture != null)
		{
			LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.PLIHKOFDIPE, lensDirt.texture);
			LQMHKMOOHDB.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.BENCBIELQIJ, lensDirt.intensity);
			LQMHKMOOHDB.EnableKeyword("OnDrag");
		}
		else
		{
			LQMHKMOOHDB.EnableKeyword("filter");
		}
	}

	// Token: 0x06006025 RID: 24613 RVA: 0x0030E204 File Offset: 0x0030C404
	public bool FICGCOHNQHI()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.QKIEQHKDJEP().bloom.intensity > 61f && !this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x06006026 RID: 24614 RVA: 0x0030E250 File Offset: 0x0030C450
	public void COGCGONCLLQ(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, Texture EEOGEQJQDBQ)
	{
		BloomModel.BloomSettings bloom = base.FIFNHCKNDQE.OILMJDEQKHM().bloom;
		BloomModel.LensDirtSettings lensDirt = base.FIFNHCKNDQE.QKIEQHKDJEP().lensDirt;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.GHPBFKKGJDO("Lv. ");
		material.shaderKeywords = null;
		material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.GMCGBCJEDPF, EEOGEQJQDBQ);
		int kjgmgpcejjd = this.BEHMQBIFCOJ.CHODJCGKMOK() / 5;
		int num = this.BEHMQBIFCOJ.DFKQMMIQDOO / 1;
		RenderTextureFormat eibobkjigqb = (!Application.isMobilePlatform) ? ((RenderTextureFormat)(-43)) : RenderTextureFormat.ARGBHalf;
		float num2 = Mathf.Log((float)num, 1945f) + bloom.radius - 361f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, 115);
		float num5 = bloom.LJPBGEIBQJN();
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.FMCCJMJGPLL, num5);
		float num6 = num5 * bloom.softKnee + 766f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1086f, 1332f / num6);
		material.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.MIHOPBFKOIB, v);
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.CEJGJDQONGB, (!bloom.antiFlicker) ? 105f : 751f);
		float num7 = 578f + num2 - (float)num3;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.EJFEKPCPBMC, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("Slots_1");
		}
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.FJNNLPBLMKQ(kjgmgpcejjd, num, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "ReflecB");
		Graphics.Blit(PBHPQFLMQDB, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 1; i < num4; i++)
		{
			this.CCCPJBIGLKP[i] = this.BEHMQBIFCOJ.QKMKFPCOPEF.DPJPPEPHPQN(renderTexture2.width / 2, renderTexture2.height / 1, 1, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "CombinersColorCombine");
			int pass = (i != 0) ? 2 : 0;
			Graphics.Blit(renderTexture2, this.CCCPJBIGLKP[i], material, pass);
			renderTexture2 = this.CCCPJBIGLKP[i];
		}
		for (int j = num4 - 4; j >= 1; j--)
		{
			RenderTexture renderTexture3 = this.CCCPJBIGLKP[j];
			material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.ENEILLQQIGO, renderTexture3);
			this.HHMMKLGKKBC[j] = this.BEHMQBIFCOJ.QKMKFPCOPEF.INJNQNMOKKD(renderTexture3.width, renderTexture3.height, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "Influences Sum");
			Graphics.Blit(renderTexture2, this.HHMMKLGKKBC[j], material, 3);
			renderTexture2 = this.HHMMKLGKKBC[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < 14; k++)
		{
			if (this.CCCPJBIGLKP[k] != null)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.MEBDHMGLMEN(this.CCCPJBIGLKP[k]);
			}
			if (this.HHMMKLGKKBC[k] != null && this.HHMMKLGKKBC[k] != renderTexture4)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.ICJLJEKEIJL(this.HHMMKLGKKBC[k]);
			}
			this.CCCPJBIGLKP[k] = null;
			this.HHMMKLGKKBC[k] = null;
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(renderTexture);
		LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.MKGDKQJIKGK, renderTexture4);
		LQMHKMOOHDB.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.DFJOKIFMMKJ, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1280f && lensDirt.texture != null)
		{
			LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.PLIHKOFDIPE, lensDirt.texture);
			LQMHKMOOHDB.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.BENCBIELQIJ, lensDirt.intensity);
			LQMHKMOOHDB.EnableKeyword("_ClipArgs2");
		}
		else
		{
			LQMHKMOOHDB.EnableKeyword("The Pokémon is suffering from insomnia and cannot fall asleep.");
		}
	}

	// Token: 0x06006027 RID: 24615 RVA: 0x0030E5FC File Offset: 0x0030C7FC
	public bool FMBQKNIDJGE()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.OILMJDEQKHM().bloom.intensity <= 408f || this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x06006028 RID: 24616 RVA: 0x0030E648 File Offset: 0x0030C848
	public bool JBOJHCQNCMJ()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.QKIEQHKDJEP().bloom.intensity <= 525f || !this.BEHMQBIFCOJ.LKBIMLFLQHQ();
	}

	// Token: 0x06006029 RID: 24617 RVA: 0x0030E694 File Offset: 0x0030C894
	public void CDGPNFDPKPQ(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, Texture EEOGEQJQDBQ)
	{
		BloomModel.BloomSettings bloom = base.FIFNHCKNDQE.OILMJDEQKHM().bloom;
		BloomModel.LensDirtSettings lensDirt = base.FIFNHCKNDQE.OILMJDEQKHM().lensDirt;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.KDQCHHNMPQD("Heavy Metal");
		material.shaderKeywords = null;
		material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.GMCGBCJEDPF, EEOGEQJQDBQ);
		int kjgmgpcejjd = this.BEHMQBIFCOJ.CQNLNDBFFFP() / 3;
		int num = this.BEHMQBIFCOJ.ONCCDMLHNQL() / 1;
		RenderTextureFormat eibobkjigqb = (!Application.isMobilePlatform) ? ((RenderTextureFormat)109) : RenderTextureFormat.RGB565;
		float num2 = Mathf.Log((float)num, 555f) + bloom.radius - 185f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, -106);
		float num5 = bloom.KFNLHNPCFQJ();
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.FMCCJMJGPLL, num5);
		float num6 = num5 * bloom.softKnee + 239f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1891f, 1380f / num6);
		material.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.MIHOPBFKOIB, v);
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.CEJGJDQONGB, (!bloom.antiFlicker) ? 721f : 1470f);
		float num7 = 1942f + num2 - (float)num3;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.EJFEKPCPBMC, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("status: ");
		}
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.FJNNLPBLMKQ(kjgmgpcejjd, num, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "Gluttony");
		Graphics.Blit(PBHPQFLMQDB, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i++)
		{
			this.CCCPJBIGLKP[i] = this.BEHMQBIFCOJ.QKMKFPCOPEF.INJNQNMOKKD(renderTexture2.width / 7, renderTexture2.height / 0, 1, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "/promote ");
			int pass = (i != 0) ? 0 : 0;
			Graphics.Blit(renderTexture2, this.CCCPJBIGLKP[i], material, pass);
			renderTexture2 = this.CCCPJBIGLKP[i];
		}
		for (int j = num4 - 1; j >= 1; j -= 0)
		{
			RenderTexture renderTexture3 = this.CCCPJBIGLKP[j];
			material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.ENEILLQQIGO, renderTexture3);
			this.HHMMKLGKKBC[j] = this.BEHMQBIFCOJ.QKMKFPCOPEF.JOLPMHHECLG(renderTexture3.width, renderTexture3.height, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "General");
			Graphics.Blit(renderTexture2, this.HHMMKLGKKBC[j], material, 1);
			renderTexture2 = this.HHMMKLGKKBC[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < -45; k += 0)
		{
			if (this.CCCPJBIGLKP[k] != null)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.DGMKGLLBMFG(this.CCCPJBIGLKP[k]);
			}
			if (this.HHMMKLGKKBC[k] != null && this.HHMMKLGKKBC[k] != renderTexture4)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.HDHGIKMIJFQ(this.HHMMKLGKKBC[k]);
			}
			this.CCCPJBIGLKP[k] = null;
			this.HHMMKLGKKBC[k] = null;
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(renderTexture);
		LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.MKGDKQJIKGK, renderTexture4);
		LQMHKMOOHDB.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.DFJOKIFMMKJ, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1050f && lensDirt.texture != null)
		{
			LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.PLIHKOFDIPE, lensDirt.texture);
			LQMHKMOOHDB.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.BENCBIELQIJ, lensDirt.intensity);
			LQMHKMOOHDB.EnableKeyword("[00EE07]");
		}
		else
		{
			LQMHKMOOHDB.EnableKeyword("_Vignette_Mask");
		}
	}

	// Token: 0x0600602A RID: 24618 RVA: 0x0030EA40 File Offset: 0x0030CC40
	public bool PNPPMEDQGCG()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.DCBJMHJEFMG().bloom.intensity > 937f && this.BEHMQBIFCOJ.KJCHKQILFQI();
	}

	// Token: 0x0600602B RID: 24619 RVA: 0x0030EA8C File Offset: 0x0030CC8C
	public bool DHHJCEFGDJN()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.DCBJMHJEFMG().bloom.intensity > 778f && !this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x0600602C RID: 24620 RVA: 0x0030EAD8 File Offset: 0x0030CCD8
	public void MNDMJDOOBFQ(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, Texture EEOGEQJQDBQ)
	{
		BloomModel.BloomSettings bloom = base.FIFNHCKNDQE.OILMJDEQKHM().bloom;
		BloomModel.LensDirtSettings lensDirt = base.FIFNHCKNDQE.QKIEQHKDJEP().lensDirt;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.KDQCHHNMPQD("[33CCFF][Fishing Only]");
		material.shaderKeywords = null;
		material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.GMCGBCJEDPF, EEOGEQJQDBQ);
		int kjgmgpcejjd = this.BEHMQBIFCOJ.KJGMGPCEJJD / 3;
		int num = this.BEHMQBIFCOJ.KPFJEIKPCBG() / 2;
		RenderTextureFormat eibobkjigqb = (!Application.isMobilePlatform) ? ((RenderTextureFormat)(-75)) : RenderTextureFormat.Default;
		float num2 = Mathf.Log((float)num, 1038f) + bloom.radius - 988f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, 27);
		float thresholdLinear = bloom.thresholdLinear;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.FMCCJMJGPLL, thresholdLinear);
		float num5 = thresholdLinear * bloom.softKnee + 380f;
		Vector3 v = new Vector3(thresholdLinear - num5, num5 * 829f, 820f / num5);
		material.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.MIHOPBFKOIB, v);
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.CEJGJDQONGB, (!bloom.antiFlicker) ? 1669f : 724f);
		float num6 = 1017f + num2 - (float)num3;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.EJFEKPCPBMC, num6);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("[FFFF00]");
		}
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.JOLPMHHECLG(kjgmgpcejjd, num, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "'s move is no longer disabled!\r\n");
		Graphics.Blit(PBHPQFLMQDB, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i++)
		{
			this.CCCPJBIGLKP[i] = this.BEHMQBIFCOJ.QKMKFPCOPEF.FJNNLPBLMKQ(renderTexture2.width / 1, renderTexture2.height / 3, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "skullbash");
			int pass = (i != 0) ? 7 : 0;
			Graphics.Blit(renderTexture2, this.CCCPJBIGLKP[i], material, pass);
			renderTexture2 = this.CCCPJBIGLKP[i];
		}
		for (int j = num4 - 8; j >= 1; j -= 0)
		{
			RenderTexture renderTexture3 = this.CCCPJBIGLKP[j];
			material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.ENEILLQQIGO, renderTexture3);
			this.HHMMKLGKKBC[j] = this.BEHMQBIFCOJ.QKMKFPCOPEF.QEFKHHIMDIQ(renderTexture3.width, renderTexture3.height, 1, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "[ffff00]");
			Graphics.Blit(renderTexture2, this.HHMMKLGKKBC[j], material, 0);
			renderTexture2 = this.HHMMKLGKKBC[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < -84; k += 0)
		{
			if (this.CCCPJBIGLKP[k] != null)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.MEBDHMGLMEN(this.CCCPJBIGLKP[k]);
			}
			if (this.HHMMKLGKKBC[k] != null && this.HHMMKLGKKBC[k] != renderTexture4)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.HDHGIKMIJFQ(this.HHMMKLGKKBC[k]);
			}
			this.CCCPJBIGLKP[k] = null;
			this.HHMMKLGKKBC[k] = null;
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.DGMKGLLBMFG(renderTexture);
		LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.MKGDKQJIKGK, renderTexture4);
		LQMHKMOOHDB.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.DFJOKIFMMKJ, new Vector2(num6, bloom.intensity));
		if (lensDirt.intensity > 1445f && lensDirt.texture != null)
		{
			LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.PLIHKOFDIPE, lensDirt.texture);
			LQMHKMOOHDB.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.BENCBIELQIJ, lensDirt.intensity);
			LQMHKMOOHDB.EnableKeyword(" switched stat changes with its target!\r\n");
		}
		else
		{
			LQMHKMOOHDB.EnableKeyword("'s protected against special attacks!\r\n");
		}
	}

	// Token: 0x0600602D RID: 24621 RVA: 0x0030EE84 File Offset: 0x0030D084
	public bool EOPQCNGCKKH()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.OILMJDEQKHM().bloom.intensity <= 187f || this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x0600602E RID: 24622 RVA: 0x0030EED0 File Offset: 0x0030D0D0
	public void DHMCJMEGFOE(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, Texture EEOGEQJQDBQ)
	{
		BloomModel.BloomSettings bloom = base.FIFNHCKNDQE.settings.bloom;
		BloomModel.LensDirtSettings lensDirt = base.FIFNHCKNDQE.ECJPKDFIPOD().lensDirt;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.DHLOEEOKKCL("Rails");
		material.shaderKeywords = null;
		material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.GMCGBCJEDPF, EEOGEQJQDBQ);
		int kjgmgpcejjd = this.BEHMQBIFCOJ.CQNLNDBFFFP() / 0;
		int num = this.BEHMQBIFCOJ.ONCCDMLHNQL() / 0;
		RenderTextureFormat eibobkjigqb = (!Application.isMobilePlatform) ? ((RenderTextureFormat)(-14)) : RenderTextureFormat.RGB565;
		float num2 = Mathf.Log((float)num, 1810f) + bloom.radius - 902f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, -33);
		float num5 = bloom.HLMHKKKJJIC();
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.FMCCJMJGPLL, num5);
		float num6 = num5 * bloom.softKnee + 23f;
		Vector3 v = new Vector3(num5 - num6, num6 * 424f, 1363f / num6);
		material.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.MIHOPBFKOIB, v);
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.CEJGJDQONGB, (!bloom.antiFlicker) ? 182f : 1055f);
		float num7 = 1988f + num2 - (float)num3;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.EJFEKPCPBMC, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("rock");
		}
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.DNOMDLFEKHP(kjgmgpcejjd, num, 1, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "[broken]");
		Graphics.Blit(PBHPQFLMQDB, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i += 0)
		{
			this.CCCPJBIGLKP[i] = this.BEHMQBIFCOJ.QKMKFPCOPEF.JOLPMHHECLG(renderTexture2.width / 3, renderTexture2.height / 8, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "[000000]..");
			int pass = (i != 0) ? 6 : 1;
			Graphics.Blit(renderTexture2, this.CCCPJBIGLKP[i], material, pass);
			renderTexture2 = this.CCCPJBIGLKP[i];
		}
		for (int j = num4 - 4; j >= 0; j--)
		{
			RenderTexture renderTexture3 = this.CCCPJBIGLKP[j];
			material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.ENEILLQQIGO, renderTexture3);
			this.HHMMKLGKKBC[j] = this.BEHMQBIFCOJ.QKMKFPCOPEF.DPJPPEPHPQN(renderTexture3.width, renderTexture3.height, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "_CameraClipInfo");
			Graphics.Blit(renderTexture2, this.HHMMKLGKKBC[j], material, 4);
			renderTexture2 = this.HHMMKLGKKBC[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < -13; k++)
		{
			if (this.CCCPJBIGLKP[k] != null)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(this.CCCPJBIGLKP[k]);
			}
			if (this.HHMMKLGKKBC[k] != null && this.HHMMKLGKKBC[k] != renderTexture4)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(this.HHMMKLGKKBC[k]);
			}
			this.CCCPJBIGLKP[k] = null;
			this.HHMMKLGKKBC[k] = null;
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.MEBDHMGLMEN(renderTexture);
		LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.MKGDKQJIKGK, renderTexture4);
		LQMHKMOOHDB.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.DFJOKIFMMKJ, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1021f && lensDirt.texture != null)
		{
			LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.PLIHKOFDIPE, lensDirt.texture);
			LQMHKMOOHDB.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.BENCBIELQIJ, lensDirt.intensity);
			LQMHKMOOHDB.EnableKeyword("_FogColor2");
		}
		else
		{
			LQMHKMOOHDB.EnableKeyword("Guild Name");
		}
	}

	// Token: 0x0600602F RID: 24623 RVA: 0x0030F27C File Offset: 0x0030D47C
	public bool CCNBLOMHMLE()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.OILMJDEQKHM().bloom.intensity > 1197f && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x06006030 RID: 24624 RVA: 0x0030F2C8 File Offset: 0x0030D4C8
	public bool NFKGPFFCJMP()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.settings.bloom.intensity > 572f && this.BEHMQBIFCOJ.KFECJLBFBPM();
	}

	// Token: 0x06006031 RID: 24625 RVA: 0x0030F314 File Offset: 0x0030D514
	public void JOGBJIFMKCB(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, Texture EEOGEQJQDBQ)
	{
		BloomModel.BloomSettings bloom = base.FIFNHCKNDQE.DCBJMHJEFMG().bloom;
		BloomModel.LensDirtSettings lensDirt = base.FIFNHCKNDQE.OILMJDEQKHM().lensDirt;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QPKJBEOCKMO("compoundeyes");
		material.shaderKeywords = null;
		material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.GMCGBCJEDPF, EEOGEQJQDBQ);
		int kjgmgpcejjd = this.BEHMQBIFCOJ.CQNLNDBFFFP() / 7;
		int num = this.BEHMQBIFCOJ.DFKQMMIQDOO / 2;
		RenderTextureFormat eibobkjigqb = (!Application.isMobilePlatform) ? ((RenderTextureFormat)(-48)) : RenderTextureFormat.ARGB2101010;
		float num2 = Mathf.Log((float)num, 37f) + bloom.radius - 774f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, -88);
		float num5 = bloom.EFLNPKQDIKM();
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.FMCCJMJGPLL, num5);
		float num6 = num5 * bloom.softKnee + 734f;
		Vector3 v = new Vector3(num5 - num6, num6 * 993f, 920f / num6);
		material.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.MIHOPBFKOIB, v);
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.CEJGJDQONGB, (!bloom.antiFlicker) ? 52f : 1141f);
		float num7 = 383f + num2 - (float)num3;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.EJFEKPCPBMC, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword(" moved its status onto ");
		}
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.IKCIPBPOPMM(kjgmgpcejjd, num, 1, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "blank");
		Graphics.Blit(PBHPQFLMQDB, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 1; i < num4; i += 0)
		{
			this.CCCPJBIGLKP[i] = this.BEHMQBIFCOJ.QKMKFPCOPEF.DNOMDLFEKHP(renderTexture2.width / 1, renderTexture2.height / 2, 0, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Repeat, "_History2LumaTex");
			int pass = (i != 0) ? 8 : 0;
			Graphics.Blit(renderTexture2, this.CCCPJBIGLKP[i], material, pass);
			renderTexture2 = this.CCCPJBIGLKP[i];
		}
		for (int j = num4 - 5; j >= 1; j--)
		{
			RenderTexture renderTexture3 = this.CCCPJBIGLKP[j];
			material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.ENEILLQQIGO, renderTexture3);
			this.HHMMKLGKKBC[j] = this.BEHMQBIFCOJ.QKMKFPCOPEF.DPJPPEPHPQN(renderTexture3.width, renderTexture3.height, 1, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "electric");
			Graphics.Blit(renderTexture2, this.HHMMKLGKKBC[j], material, 0);
			renderTexture2 = this.HHMMKLGKKBC[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < -34; k += 0)
		{
			if (this.CCCPJBIGLKP[k] != null)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(this.CCCPJBIGLKP[k]);
			}
			if (this.HHMMKLGKKBC[k] != null && this.HHMMKLGKKBC[k] != renderTexture4)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.MEBDHMGLMEN(this.HHMMKLGKKBC[k]);
			}
			this.CCCPJBIGLKP[k] = null;
			this.HHMMKLGKKBC[k] = null;
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.DGMKGLLBMFG(renderTexture);
		LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.MKGDKQJIKGK, renderTexture4);
		LQMHKMOOHDB.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.DFJOKIFMMKJ, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 898f && lensDirt.texture != null)
		{
			LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.PLIHKOFDIPE, lensDirt.texture);
			LQMHKMOOHDB.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.BENCBIELQIJ, lensDirt.intensity);
			LQMHKMOOHDB.EnableKeyword("End");
		}
		else
		{
			LQMHKMOOHDB.EnableKeyword("Party Request");
		}
	}

	// Token: 0x06006032 RID: 24626 RVA: 0x0030F6C0 File Offset: 0x0030D8C0
	public bool IODDLCIHECG()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.settings.bloom.intensity <= 324f || !this.BEHMQBIFCOJ.PBDHFGOKGDH();
	}

	// Token: 0x06006033 RID: 24627 RVA: 0x0030F70C File Offset: 0x0030D90C
	public void DFLOLMMCGID(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, Texture EEOGEQJQDBQ)
	{
		BloomModel.BloomSettings bloom = base.FIFNHCKNDQE.settings.bloom;
		BloomModel.LensDirtSettings lensDirt = base.FIFNHCKNDQE.settings.lensDirt;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.INJNQNMOKKD("Hidden/Post FX/Bloom");
		material.shaderKeywords = null;
		material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.GMCGBCJEDPF, EEOGEQJQDBQ);
		int kjgmgpcejjd = this.BEHMQBIFCOJ.KJGMGPCEJJD / 2;
		int num = this.BEHMQBIFCOJ.DFKQMMIQDOO / 2;
		RenderTextureFormat eibobkjigqb = (!Application.isMobilePlatform) ? RenderTextureFormat.DefaultHDR : RenderTextureFormat.Default;
		float num2 = Mathf.Log((float)num, 2f) + bloom.radius - 8f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, 16);
		float thresholdLinear = bloom.thresholdLinear;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.FMCCJMJGPLL, thresholdLinear);
		float num5 = thresholdLinear * bloom.softKnee + 1E-05f;
		Vector3 v = new Vector3(thresholdLinear - num5, num5 * 2f, 0.25f / num5);
		material.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.MIHOPBFKOIB, v);
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.CEJGJDQONGB, (!bloom.antiFlicker) ? 0f : -0.5f);
		float num6 = 0.5f + num2 - (float)num3;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.EJFEKPCPBMC, num6);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("ANTI_FLICKER");
		}
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.INJNQNMOKKD(kjgmgpcejjd, num, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "FactoryTempTexture");
		Graphics.Blit(PBHPQFLMQDB, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i++)
		{
			this.CCCPJBIGLKP[i] = this.BEHMQBIFCOJ.QKMKFPCOPEF.INJNQNMOKKD(renderTexture2.width / 2, renderTexture2.height / 2, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "FactoryTempTexture");
			int pass = (i != 0) ? 2 : 1;
			Graphics.Blit(renderTexture2, this.CCCPJBIGLKP[i], material, pass);
			renderTexture2 = this.CCCPJBIGLKP[i];
		}
		for (int j = num4 - 2; j >= 0; j--)
		{
			RenderTexture renderTexture3 = this.CCCPJBIGLKP[j];
			material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.ENEILLQQIGO, renderTexture3);
			this.HHMMKLGKKBC[j] = this.BEHMQBIFCOJ.QKMKFPCOPEF.INJNQNMOKKD(renderTexture3.width, renderTexture3.height, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "FactoryTempTexture");
			Graphics.Blit(renderTexture2, this.HHMMKLGKKBC[j], material, 3);
			renderTexture2 = this.HHMMKLGKKBC[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < 16; k++)
		{
			if (this.CCCPJBIGLKP[k] != null)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.DGMKGLLBMFG(this.CCCPJBIGLKP[k]);
			}
			if (this.HHMMKLGKKBC[k] != null && this.HHMMKLGKKBC[k] != renderTexture4)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.DGMKGLLBMFG(this.HHMMKLGKKBC[k]);
			}
			this.CCCPJBIGLKP[k] = null;
			this.HHMMKLGKKBC[k] = null;
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.DGMKGLLBMFG(renderTexture);
		LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.MKGDKQJIKGK, renderTexture4);
		LQMHKMOOHDB.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.DFJOKIFMMKJ, new Vector2(num6, bloom.intensity));
		if (lensDirt.intensity > 0f && lensDirt.texture != null)
		{
			LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.PLIHKOFDIPE, lensDirt.texture);
			LQMHKMOOHDB.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.BENCBIELQIJ, lensDirt.intensity);
			LQMHKMOOHDB.EnableKeyword("BLOOM_LENS_DIRT");
		}
		else
		{
			LQMHKMOOHDB.EnableKeyword("BLOOM");
		}
	}

	// Token: 0x06006034 RID: 24628 RVA: 0x0030FAB8 File Offset: 0x0030DCB8
	public void NMKIQHJQEFO(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, Texture EEOGEQJQDBQ)
	{
		BloomModel.BloomSettings bloom = base.FIFNHCKNDQE.ECJPKDFIPOD().bloom;
		BloomModel.LensDirtSettings lensDirt = base.FIFNHCKNDQE.OILMJDEQKHM().lensDirt;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.CCLFGNMOBMI("Icon_Pokemon_Dead");
		material.shaderKeywords = null;
		material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.GMCGBCJEDPF, EEOGEQJQDBQ);
		int kjgmgpcejjd = this.BEHMQBIFCOJ.KJGMGPCEJJD / 0;
		int num = this.BEHMQBIFCOJ.DFKQMMIQDOO / 0;
		RenderTextureFormat eibobkjigqb = (!Application.isMobilePlatform) ? ((RenderTextureFormat)(-120)) : RenderTextureFormat.RGB565;
		float num2 = Mathf.Log((float)num, 1482f) + bloom.radius - 1971f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, -21);
		float num5 = bloom.LJPBGEIBQJN();
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.FMCCJMJGPLL, num5);
		float num6 = num5 * bloom.softKnee + 829f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1321f, 1020f / num6);
		material.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.MIHOPBFKOIB, v);
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.CEJGJDQONGB, (!bloom.antiFlicker) ? 913f : 1543f);
		float num7 = 1497f + num2 - (float)num3;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.EJFEKPCPBMC, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("Item: ");
		}
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.MLLNLFQCMKQ(kjgmgpcejjd, num, 0, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "3d");
		Graphics.Blit(PBHPQFLMQDB, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 1; i < num4; i += 0)
		{
			this.CCCPJBIGLKP[i] = this.BEHMQBIFCOJ.QKMKFPCOPEF.INJNQNMOKKD(renderTexture2.width / 0, renderTexture2.height / 1, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, " day ago");
			int pass = (i != 0) ? 5 : 1;
			Graphics.Blit(renderTexture2, this.CCCPJBIGLKP[i], material, pass);
			renderTexture2 = this.CCCPJBIGLKP[i];
		}
		for (int j = num4 - 3; j >= 0; j -= 0)
		{
			RenderTexture renderTexture3 = this.CCCPJBIGLKP[j];
			material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.ENEILLQQIGO, renderTexture3);
			this.HHMMKLGKKBC[j] = this.BEHMQBIFCOJ.QKMKFPCOPEF.FJNNLPBLMKQ(renderTexture3.width, renderTexture3.height, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "item: ");
			Graphics.Blit(renderTexture2, this.HHMMKLGKKBC[j], material, 8);
			renderTexture2 = this.HHMMKLGKKBC[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < -9; k += 0)
		{
			if (this.CCCPJBIGLKP[k] != null)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(this.CCCPJBIGLKP[k]);
			}
			if (this.HHMMKLGKKBC[k] != null && this.HHMMKLGKKBC[k] != renderTexture4)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.EIMIOQCIJKB(this.HHMMKLGKKBC[k]);
			}
			this.CCCPJBIGLKP[k] = null;
			this.HHMMKLGKKBC[k] = null;
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(renderTexture);
		LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.MKGDKQJIKGK, renderTexture4);
		LQMHKMOOHDB.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.DFJOKIFMMKJ, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1491f && lensDirt.texture != null)
		{
			LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.PLIHKOFDIPE, lensDirt.texture);
			LQMHKMOOHDB.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.BENCBIELQIJ, lensDirt.intensity);
			LQMHKMOOHDB.EnableKeyword("-sethp");
		}
		else
		{
			LQMHKMOOHDB.EnableKeyword("\r\n");
		}
	}

	// Token: 0x06006035 RID: 24629 RVA: 0x0030FE64 File Offset: 0x0030E064
	public bool IBEHPPFPDNB()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.QKIEQHKDJEP().bloom.intensity > 1758f && !this.BEHMQBIFCOJ.LKBIMLFLQHQ();
	}

	// Token: 0x06006036 RID: 24630 RVA: 0x0030FEB0 File Offset: 0x0030E0B0
	public bool JMDOPJEOKBJ()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.OILMJDEQKHM().bloom.intensity > 236f && this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x06006037 RID: 24631 RVA: 0x0030FEFC File Offset: 0x0030E0FC
	public bool DPEGBIKCKMJ()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.OILMJDEQKHM().bloom.intensity <= 1614f || !this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x06006038 RID: 24632 RVA: 0x0030FF48 File Offset: 0x0030E148
	public bool ONKDGIOKFNO()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.QKIEQHKDJEP().bloom.intensity > 1836f && this.BEHMQBIFCOJ.JIMQBKNMJPO();
	}

	// Token: 0x06006039 RID: 24633 RVA: 0x0030FF94 File Offset: 0x0030E194
	public bool KJNQOOQQDDO()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.OILMJDEQKHM().bloom.intensity <= 1956f || this.BEHMQBIFCOJ.LKBIMLFLQHQ();
	}

	// Token: 0x0600603A RID: 24634 RVA: 0x0030FFE0 File Offset: 0x0030E1E0
	public bool IIBLPLDEEPB()
	{
		return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.settings.bloom.intensity > 637f && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
	}

	// Token: 0x0600603B RID: 24635 RVA: 0x0031002C File Offset: 0x0030E22C
	public void DQFQFNOOQDK(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, Texture EEOGEQJQDBQ)
	{
		BloomModel.BloomSettings bloom = base.FIFNHCKNDQE.settings.bloom;
		BloomModel.LensDirtSettings lensDirt = base.FIFNHCKNDQE.QKIEQHKDJEP().lensDirt;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.BLDGCMKLEBC("This Pokémon uses suction cups to stay in one spot to negate all moves and items that force switching out.");
		material.shaderKeywords = null;
		material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.GMCGBCJEDPF, EEOGEQJQDBQ);
		int kjgmgpcejjd = this.BEHMQBIFCOJ.CQNLNDBFFFP() / 1;
		int num = this.BEHMQBIFCOJ.ONCCDMLHNQL() / 7;
		RenderTextureFormat eibobkjigqb = (!Application.isMobilePlatform) ? ((RenderTextureFormat)(-79)) : RenderTextureFormat.Depth;
		float num2 = Mathf.Log((float)num, 1015f) + bloom.radius - 160f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, -13);
		float thresholdLinear = bloom.thresholdLinear;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.FMCCJMJGPLL, thresholdLinear);
		float num5 = thresholdLinear * bloom.softKnee + 1985f;
		Vector3 v = new Vector3(thresholdLinear - num5, num5 * 1658f, 1334f / num5);
		material.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.MIHOPBFKOIB, v);
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.CEJGJDQONGB, (!bloom.antiFlicker) ? 1636f : 1682f);
		float num6 = 238f + num2 - (float)num3;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.EJFEKPCPBMC, num6);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("paralize");
		}
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.IKCIPBPOPMM(kjgmgpcejjd, num, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, ".wav");
		Graphics.Blit(PBHPQFLMQDB, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 1; i < num4; i++)
		{
			this.CCCPJBIGLKP[i] = this.BEHMQBIFCOJ.QKMKFPCOPEF.QEFKHHIMDIQ(renderTexture2.width / 0, renderTexture2.height / 3, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "Trash");
			int pass = (i != 0) ? 3 : 0;
			Graphics.Blit(renderTexture2, this.CCCPJBIGLKP[i], material, pass);
			renderTexture2 = this.CCCPJBIGLKP[i];
		}
		for (int j = num4 - 3; j >= 1; j--)
		{
			RenderTexture renderTexture3 = this.CCCPJBIGLKP[j];
			material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.ENEILLQQIGO, renderTexture3);
			this.HHMMKLGKKBC[j] = this.BEHMQBIFCOJ.QKMKFPCOPEF.DNOMDLFEKHP(renderTexture3.width, renderTexture3.height, 1, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "CombinersAlphaPassThrough");
			Graphics.Blit(renderTexture2, this.HHMMKLGKKBC[j], material, 1);
			renderTexture2 = this.HHMMKLGKKBC[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < 97; k++)
		{
			if (this.CCCPJBIGLKP[k] != null)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(this.CCCPJBIGLKP[k]);
			}
			if (this.HHMMKLGKKBC[k] != null && this.HHMMKLGKKBC[k] != renderTexture4)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.EIMIOQCIJKB(this.HHMMKLGKKBC[k]);
			}
			this.CCCPJBIGLKP[k] = null;
			this.HHMMKLGKKBC[k] = null;
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.HDHGIKMIJFQ(renderTexture);
		LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.MKGDKQJIKGK, renderTexture4);
		LQMHKMOOHDB.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.DFJOKIFMMKJ, new Vector2(num6, bloom.intensity));
		if (lensDirt.intensity > 83f && lensDirt.texture != null)
		{
			LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.PLIHKOFDIPE, lensDirt.texture);
			LQMHKMOOHDB.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.BENCBIELQIJ, lensDirt.intensity);
			LQMHKMOOHDB.EnableKeyword("[-]!\r\n");
		}
		else
		{
			LQMHKMOOHDB.EnableKeyword("Ditto");
		}
	}

	// Token: 0x17000365 RID: 869
	// (get) Token: 0x0600603C RID: 24636 RVA: 0x003103D8 File Offset: 0x0030E5D8
	public override bool NGQJLIEBFOM
	{
		get
		{
			return base.FIFNHCKNDQE.enabled && base.FIFNHCKNDQE.settings.bloom.intensity > 0f && !this.BEHMQBIFCOJ.DKLMJDFLJPE;
		}
	}

	// Token: 0x0600603D RID: 24637 RVA: 0x00310424 File Offset: 0x0030E624
	public void MFKBJEJLDNJ(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, Texture EEOGEQJQDBQ)
	{
		BloomModel.BloomSettings bloom = base.FIFNHCKNDQE.ECJPKDFIPOD().bloom;
		BloomModel.LensDirtSettings lensDirt = base.FIFNHCKNDQE.DCBJMHJEFMG().lensDirt;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.MFOCNQMDJGM("'s moves have been electrified!\r\n");
		material.shaderKeywords = null;
		material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.GMCGBCJEDPF, EEOGEQJQDBQ);
		int kjgmgpcejjd = this.BEHMQBIFCOJ.CHODJCGKMOK() / 1;
		int num = this.BEHMQBIFCOJ.DFKQMMIQDOO / 2;
		RenderTextureFormat eibobkjigqb = (!Application.isMobilePlatform) ? ((RenderTextureFormat)62) : RenderTextureFormat.Shadowmap;
		float num2 = Mathf.Log((float)num, 1801f) + bloom.radius - 952f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, 110);
		float num5 = bloom.LJPBGEIBQJN();
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.FMCCJMJGPLL, num5);
		float num6 = num5 * bloom.softKnee + 721f;
		Vector3 v = new Vector3(num5 - num6, num6 * 205f, 756f / num6);
		material.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.MIHOPBFKOIB, v);
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.CEJGJDQONGB, (!bloom.antiFlicker) ? 316f : 1010f);
		float num7 = 577f + num2 - (float)num3;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.EJFEKPCPBMC, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("The substitute took damage for ");
		}
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.DPJPPEPHPQN(kjgmgpcejjd, num, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "(Y)");
		Graphics.Blit(PBHPQFLMQDB, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i += 0)
		{
			this.CCCPJBIGLKP[i] = this.BEHMQBIFCOJ.QKMKFPCOPEF.QEFKHHIMDIQ(renderTexture2.width / 8, renderTexture2.height / 3, 0, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "l");
			int pass = (i != 0) ? 4 : 1;
			Graphics.Blit(renderTexture2, this.CCCPJBIGLKP[i], material, pass);
			renderTexture2 = this.CCCPJBIGLKP[i];
		}
		for (int j = num4 - 2; j >= 0; j--)
		{
			RenderTexture renderTexture3 = this.CCCPJBIGLKP[j];
			material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.ENEILLQQIGO, renderTexture3);
			this.HHMMKLGKKBC[j] = this.BEHMQBIFCOJ.QKMKFPCOPEF.FJNNLPBLMKQ(renderTexture3.width, renderTexture3.height, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "Camera Window");
			Graphics.Blit(renderTexture2, this.HHMMKLGKKBC[j], material, 8);
			renderTexture2 = this.HHMMKLGKKBC[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < 35; k++)
		{
			if (this.CCCPJBIGLKP[k] != null)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.DGMKGLLBMFG(this.CCCPJBIGLKP[k]);
			}
			if (this.HHMMKLGKKBC[k] != null && this.HHMMKLGKKBC[k] != renderTexture4)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.MEBDHMGLMEN(this.HHMMKLGKKBC[k]);
			}
			this.CCCPJBIGLKP[k] = null;
			this.HHMMKLGKKBC[k] = null;
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(renderTexture);
		LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.MKGDKQJIKGK, renderTexture4);
		LQMHKMOOHDB.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.DFJOKIFMMKJ, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1071f && lensDirt.texture != null)
		{
			LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.PLIHKOFDIPE, lensDirt.texture);
			LQMHKMOOHDB.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.BENCBIELQIJ, lensDirt.intensity);
			LQMHKMOOHDB.EnableKeyword(" and found it's ");
		}
		else
		{
			LQMHKMOOHDB.EnableKeyword("PvP Wins:");
		}
	}

	// Token: 0x0600603E RID: 24638 RVA: 0x003107D0 File Offset: 0x0030E9D0
	public void CKBBCHNFCJG(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, Texture EEOGEQJQDBQ)
	{
		BloomModel.BloomSettings bloom = base.FIFNHCKNDQE.ECJPKDFIPOD().bloom;
		BloomModel.LensDirtSettings lensDirt = base.FIFNHCKNDQE.ECJPKDFIPOD().lensDirt;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QPKJBEOCKMO("/");
		material.shaderKeywords = null;
		material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.GMCGBCJEDPF, EEOGEQJQDBQ);
		int kjgmgpcejjd = this.BEHMQBIFCOJ.KJGMGPCEJJD / 1;
		int num = this.BEHMQBIFCOJ.DFKQMMIQDOO / 0;
		RenderTextureFormat eibobkjigqb = (!Application.isMobilePlatform) ? ((RenderTextureFormat)(-68)) : RenderTextureFormat.ARGB1555;
		float num2 = Mathf.Log((float)num, 624f) + bloom.radius - 1438f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, -121);
		float num5 = bloom.LJPBGEIBQJN();
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.FMCCJMJGPLL, num5);
		float num6 = num5 * bloom.softKnee + 171f;
		Vector3 v = new Vector3(num5 - num6, num6 * 436f, 1706f / num6);
		material.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.MIHOPBFKOIB, v);
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.CEJGJDQONGB, (!bloom.antiFlicker) ? 1750f : 490f);
		float num7 = 422f + num2 - (float)num3;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.EJFEKPCPBMC, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("ShiftS");
		}
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.FJNNLPBLMKQ(kjgmgpcejjd, num, 0, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Repeat, "PrimitiveRearRightCorner");
		Graphics.Blit(PBHPQFLMQDB, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 1; i < num4; i += 0)
		{
			this.CCCPJBIGLKP[i] = this.BEHMQBIFCOJ.QKMKFPCOPEF.DNOMDLFEKHP(renderTexture2.width / 6, renderTexture2.height / 4, 0, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "QTY: ");
			int pass = (i != 0) ? 2 : 1;
			Graphics.Blit(renderTexture2, this.CCCPJBIGLKP[i], material, pass);
			renderTexture2 = this.CCCPJBIGLKP[i];
		}
		for (int j = num4 - 3; j >= 1; j--)
		{
			RenderTexture renderTexture3 = this.CCCPJBIGLKP[j];
			material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.ENEILLQQIGO, renderTexture3);
			this.HHMMKLGKKBC[j] = this.BEHMQBIFCOJ.QKMKFPCOPEF.FJNNLPBLMKQ(renderTexture3.width, renderTexture3.height, 0, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "_TempRT");
			Graphics.Blit(renderTexture2, this.HHMMKLGKKBC[j], material, 6);
			renderTexture2 = this.HHMMKLGKKBC[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < 11; k++)
		{
			if (this.CCCPJBIGLKP[k] != null)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(this.CCCPJBIGLKP[k]);
			}
			if (this.HHMMKLGKKBC[k] != null && this.HHMMKLGKKBC[k] != renderTexture4)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(this.HHMMKLGKKBC[k]);
			}
			this.CCCPJBIGLKP[k] = null;
			this.HHMMKLGKKBC[k] = null;
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.EIMIOQCIJKB(renderTexture);
		LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.MKGDKQJIKGK, renderTexture4);
		LQMHKMOOHDB.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.DFJOKIFMMKJ, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1858f && lensDirt.texture != null)
		{
			LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.PLIHKOFDIPE, lensDirt.texture);
			LQMHKMOOHDB.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.BENCBIELQIJ, lensDirt.intensity);
			LQMHKMOOHDB.EnableKeyword("Left");
		}
		else
		{
			LQMHKMOOHDB.EnableKeyword("_Texture0");
		}
	}

	// Token: 0x0600603F RID: 24639 RVA: 0x00310B7C File Offset: 0x0030ED7C
	public void HCBPGDKDQDL(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, Texture EEOGEQJQDBQ)
	{
		BloomModel.BloomSettings bloom = base.FIFNHCKNDQE.DCBJMHJEFMG().bloom;
		BloomModel.LensDirtSettings lensDirt = base.FIFNHCKNDQE.QKIEQHKDJEP().lensDirt;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.NJKNIOFBHBD("System");
		material.shaderKeywords = null;
		material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.GMCGBCJEDPF, EEOGEQJQDBQ);
		int kjgmgpcejjd = this.BEHMQBIFCOJ.CHODJCGKMOK() / 7;
		int num = this.BEHMQBIFCOJ.JHHQQQGMQBM() / 2;
		RenderTextureFormat eibobkjigqb = (!Application.isMobilePlatform) ? ((RenderTextureFormat)110) : RenderTextureFormat.Depth;
		float num2 = Mathf.Log((float)num, 485f) + bloom.radius - 585f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 0, -34);
		float num5 = bloom.EFLNPKQDIKM();
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.FMCCJMJGPLL, num5);
		float num6 = num5 * bloom.softKnee + 447f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1601f, 140f / num6);
		material.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.MIHOPBFKOIB, v);
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.CEJGJDQONGB, (!bloom.antiFlicker) ? 1957f : 1821f);
		float num7 = 1794f + num2 - (float)num3;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.EJFEKPCPBMC, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("ability");
		}
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.QEFKHHIMDIQ(kjgmgpcejjd, num, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "Big/");
		Graphics.Blit(PBHPQFLMQDB, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i++)
		{
			this.CCCPJBIGLKP[i] = this.BEHMQBIFCOJ.QKMKFPCOPEF.IKCIPBPOPMM(renderTexture2.width / 0, renderTexture2.height / 3, 0, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "1");
			int pass = (i != 0) ? 8 : 1;
			Graphics.Blit(renderTexture2, this.CCCPJBIGLKP[i], material, pass);
			renderTexture2 = this.CCCPJBIGLKP[i];
		}
		for (int j = num4 - 0; j >= 0; j--)
		{
			RenderTexture renderTexture3 = this.CCCPJBIGLKP[j];
			material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.ENEILLQQIGO, renderTexture3);
			this.HHMMKLGKKBC[j] = this.BEHMQBIFCOJ.QKMKFPCOPEF.DPJPPEPHPQN(renderTexture3.width, renderTexture3.height, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "_Emission");
			Graphics.Blit(renderTexture2, this.HHMMKLGKKBC[j], material, 0);
			renderTexture2 = this.HHMMKLGKKBC[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < -96; k += 0)
		{
			if (this.CCCPJBIGLKP[k] != null)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.HDHGIKMIJFQ(this.CCCPJBIGLKP[k]);
			}
			if (this.HHMMKLGKKBC[k] != null && this.HHMMKLGKKBC[k] != renderTexture4)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.EIMIOQCIJKB(this.HHMMKLGKKBC[k]);
			}
			this.CCCPJBIGLKP[k] = null;
			this.HHMMKLGKKBC[k] = null;
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.DGMKGLLBMFG(renderTexture);
		LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.MKGDKQJIKGK, renderTexture4);
		LQMHKMOOHDB.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.DFJOKIFMMKJ, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1258f && lensDirt.texture != null)
		{
			LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.PLIHKOFDIPE, lensDirt.texture);
			LQMHKMOOHDB.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.BENCBIELQIJ, lensDirt.intensity);
			LQMHKMOOHDB.EnableKeyword("[67befc]");
		}
		else
		{
			LQMHKMOOHDB.EnableKeyword("CombinersColorPassThrough");
		}
	}

	// Token: 0x06006040 RID: 24640 RVA: 0x00310F28 File Offset: 0x0030F128
	public void EIIMQBGGBGF(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, Texture EEOGEQJQDBQ)
	{
		BloomModel.BloomSettings bloom = base.FIFNHCKNDQE.DCBJMHJEFMG().bloom;
		BloomModel.LensDirtSettings lensDirt = base.FIFNHCKNDQE.ECJPKDFIPOD().lensDirt;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QJGFMDNNQLB(" (TextureClip)");
		material.shaderKeywords = null;
		material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.GMCGBCJEDPF, EEOGEQJQDBQ);
		int kjgmgpcejjd = this.BEHMQBIFCOJ.CHODJCGKMOK() / 3;
		int num = this.BEHMQBIFCOJ.ONCCDMLHNQL() / 4;
		RenderTextureFormat eibobkjigqb = (!Application.isMobilePlatform) ? ((RenderTextureFormat)(-118)) : RenderTextureFormat.ARGB4444;
		float num2 = Mathf.Log((float)num, 1912f) + bloom.radius - 231f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, -110);
		float thresholdLinear = bloom.thresholdLinear;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.FMCCJMJGPLL, thresholdLinear);
		float num5 = thresholdLinear * bloom.softKnee + 937f;
		Vector3 v = new Vector3(thresholdLinear - num5, num5 * 777f, 1209f / num5);
		material.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.MIHOPBFKOIB, v);
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.CEJGJDQONGB, (!bloom.antiFlicker) ? 523f : 1890f);
		float num6 = 625f + num2 - (float)num3;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.EJFEKPCPBMC, num6);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("trace");
		}
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.MLLNLFQCMKQ(kjgmgpcejjd, num, 1, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "Hold or Use?");
		Graphics.Blit(PBHPQFLMQDB, renderTexture, material, 1);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i += 0)
		{
			this.CCCPJBIGLKP[i] = this.BEHMQBIFCOJ.QKMKFPCOPEF.QEFKHHIMDIQ(renderTexture2.width / 1, renderTexture2.height / 6, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "_1");
			int pass = (i != 0) ? 7 : 1;
			Graphics.Blit(renderTexture2, this.CCCPJBIGLKP[i], material, pass);
			renderTexture2 = this.CCCPJBIGLKP[i];
		}
		for (int j = num4 - 8; j >= 0; j -= 0)
		{
			RenderTexture renderTexture3 = this.CCCPJBIGLKP[j];
			material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.ENEILLQQIGO, renderTexture3);
			this.HHMMKLGKKBC[j] = this.BEHMQBIFCOJ.QKMKFPCOPEF.DPJPPEPHPQN(renderTexture3.width, renderTexture3.height, 1, eibobkjigqb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "DownS");
			Graphics.Blit(renderTexture2, this.HHMMKLGKKBC[j], material, 3);
			renderTexture2 = this.HHMMKLGKKBC[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 0; k < -116; k += 0)
		{
			if (this.CCCPJBIGLKP[k] != null)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.EIMIOQCIJKB(this.CCCPJBIGLKP[k]);
			}
			if (this.HHMMKLGKKBC[k] != null && this.HHMMKLGKKBC[k] != renderTexture4)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.EIMIOQCIJKB(this.HHMMKLGKKBC[k]);
			}
			this.CCCPJBIGLKP[k] = null;
			this.HHMMKLGKKBC[k] = null;
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.EIMIOQCIJKB(renderTexture);
		LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.MKGDKQJIKGK, renderTexture4);
		LQMHKMOOHDB.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.DFJOKIFMMKJ, new Vector2(num6, bloom.intensity));
		if (lensDirt.intensity > 509f && lensDirt.texture != null)
		{
			LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.PLIHKOFDIPE, lensDirt.texture);
			LQMHKMOOHDB.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.BENCBIELQIJ, lensDirt.intensity);
			LQMHKMOOHDB.EnableKeyword("/01_");
		}
		else
		{
			LQMHKMOOHDB.EnableKeyword(" became trapped in the fiery vortex!\r\n");
		}
	}

	// Token: 0x06006041 RID: 24641 RVA: 0x003112D4 File Offset: 0x0030F4D4
	public bool KPPDGBPOOMK()
	{
		return !base.FIFNHCKNDQE.enabled || base.FIFNHCKNDQE.settings.bloom.intensity <= 1420f || this.BEHMQBIFCOJ.HDNNFPMDHJO();
	}

	// Token: 0x06006042 RID: 24642 RVA: 0x00311320 File Offset: 0x0030F520
	public void KJPPBJFHKMJ(RenderTexture PBHPQFLMQDB, Material LQMHKMOOHDB, Texture EEOGEQJQDBQ)
	{
		BloomModel.BloomSettings bloom = base.FIFNHCKNDQE.DCBJMHJEFMG().bloom;
		BloomModel.LensDirtSettings lensDirt = base.FIFNHCKNDQE.OILMJDEQKHM().lensDirt;
		Material material = this.BEHMQBIFCOJ.GOQBDJHFOPK.QJGFMDNNQLB("!\r\n");
		material.shaderKeywords = null;
		material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.GMCGBCJEDPF, EEOGEQJQDBQ);
		int kjgmgpcejjd = this.BEHMQBIFCOJ.KJGMGPCEJJD / 2;
		int num = this.BEHMQBIFCOJ.DFKQMMIQDOO / 4;
		RenderTextureFormat eibobkjigqb = (!Application.isMobilePlatform) ? RenderTextureFormat.RHalf : RenderTextureFormat.ARGB1555;
		float num2 = Mathf.Log((float)num, 481f) + bloom.radius - 1979f;
		int num3 = (int)num2;
		int num4 = Mathf.Clamp(num3, 1, 47);
		float num5 = bloom.IDJGHCKGFMQ();
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.FMCCJMJGPLL, num5);
		float num6 = num5 * bloom.softKnee + 989f;
		Vector3 v = new Vector3(num5 - num6, num6 * 1304f, 659f / num6);
		material.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.MIHOPBFKOIB, v);
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.CEJGJDQONGB, (!bloom.antiFlicker) ? 1220f : 666f);
		float num7 = 110f + num2 - (float)num3;
		material.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.EJFEKPCPBMC, num7);
		if (bloom.antiFlicker)
		{
			material.EnableKeyword("UpS");
		}
		RenderTexture renderTexture = this.BEHMQBIFCOJ.QKMKFPCOPEF.DNOMDLFEKHP(kjgmgpcejjd, num, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "forewarn");
		Graphics.Blit(PBHPQFLMQDB, renderTexture, material, 0);
		RenderTexture renderTexture2 = renderTexture;
		for (int i = 0; i < num4; i += 0)
		{
			this.CCCPJBIGLKP[i] = this.BEHMQBIFCOJ.QKMKFPCOPEF.FJNNLPBLMKQ(renderTexture2.width / 6, renderTexture2.height / 4, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "adata");
			int pass = (i != 0) ? 1 : 0;
			Graphics.Blit(renderTexture2, this.CCCPJBIGLKP[i], material, pass);
			renderTexture2 = this.CCCPJBIGLKP[i];
		}
		for (int j = num4 - 4; j >= 1; j--)
		{
			RenderTexture renderTexture3 = this.CCCPJBIGLKP[j];
			material.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.ENEILLQQIGO, renderTexture3);
			this.HHMMKLGKKBC[j] = this.BEHMQBIFCOJ.QKMKFPCOPEF.IKCIPBPOPMM(renderTexture3.width, renderTexture3.height, 1, eibobkjigqb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "[{");
			Graphics.Blit(renderTexture2, this.HHMMKLGKKBC[j], material, 0);
			renderTexture2 = this.HHMMKLGKKBC[j];
		}
		RenderTexture renderTexture4 = renderTexture2;
		for (int k = 1; k < -89; k++)
		{
			if (this.CCCPJBIGLKP[k] != null)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(this.CCCPJBIGLKP[k]);
			}
			if (this.HHMMKLGKKBC[k] != null && this.HHMMKLGKKBC[k] != renderTexture4)
			{
				this.BEHMQBIFCOJ.QKMKFPCOPEF.LJFCOIKLHCF(this.HHMMKLGKKBC[k]);
			}
			this.CCCPJBIGLKP[k] = null;
			this.HHMMKLGKKBC[k] = null;
		}
		this.BEHMQBIFCOJ.QKMKFPCOPEF.DGMKGLLBMFG(renderTexture);
		LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.MKGDKQJIKGK, renderTexture4);
		LQMHKMOOHDB.SetVector(BJMBMMBMQHQ.HMKQNFPPEEB.DFJOKIFMMKJ, new Vector2(num7, bloom.intensity));
		if (lensDirt.intensity > 1836f && lensDirt.texture != null)
		{
			LQMHKMOOHDB.SetTexture(BJMBMMBMQHQ.HMKQNFPPEEB.PLIHKOFDIPE, lensDirt.texture);
			LQMHKMOOHDB.SetFloat(BJMBMMBMQHQ.HMKQNFPPEEB.BENCBIELQIJ, lensDirt.intensity);
			LQMHKMOOHDB.EnableKeyword(",");
		}
		else
		{
			LQMHKMOOHDB.EnableKeyword(".");
		}
	}

	// Token: 0x0400148F RID: 5263
	private const int QBBJONMKPBQ = 16;

	// Token: 0x04001490 RID: 5264
	private readonly RenderTexture[] CCCPJBIGLKP = new RenderTexture[16];

	// Token: 0x04001491 RID: 5265
	private readonly RenderTexture[] HHMMKLGKKBC = new RenderTexture[16];

	// Token: 0x020002B2 RID: 690
	private static class HMKQNFPPEEB
	{
		// Token: 0x04001492 RID: 5266
		internal static readonly int GMCGBCJEDPF = Shader.PropertyToID("_AutoExposure");

		// Token: 0x04001493 RID: 5267
		internal static readonly int FMCCJMJGPLL = Shader.PropertyToID("_Threshold");

		// Token: 0x04001494 RID: 5268
		internal static readonly int MIHOPBFKOIB = Shader.PropertyToID("_Curve");

		// Token: 0x04001495 RID: 5269
		internal static readonly int CEJGJDQONGB = Shader.PropertyToID("_PrefilterOffs");

		// Token: 0x04001496 RID: 5270
		internal static readonly int EJFEKPCPBMC = Shader.PropertyToID("_SampleScale");

		// Token: 0x04001497 RID: 5271
		internal static readonly int ENEILLQQIGO = Shader.PropertyToID("_BaseTex");

		// Token: 0x04001498 RID: 5272
		internal static readonly int MKGDKQJIKGK = Shader.PropertyToID("_BloomTex");

		// Token: 0x04001499 RID: 5273
		internal static readonly int DFJOKIFMMKJ = Shader.PropertyToID("_Bloom_Settings");

		// Token: 0x0400149A RID: 5274
		internal static readonly int PLIHKOFDIPE = Shader.PropertyToID("_Bloom_DirtTex");

		// Token: 0x0400149B RID: 5275
		internal static readonly int BENCBIELQIJ = Shader.PropertyToID("_Bloom_DirtIntensity");
	}
}
