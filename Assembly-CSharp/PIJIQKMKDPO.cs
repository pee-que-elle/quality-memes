using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200031C RID: 796
public sealed class PIJIQKMKDPO : IDisposable
{
	// Token: 0x06006AB3 RID: 27315 RVA: 0x00028125 File Offset: 0x00026325
	public void HDHGIKMIJFQ(RenderTexture EMKLHBIMGDN)
	{
		if (EMKLHBIMGDN == null)
		{
			return;
		}
		if (!this.PJPCIMJDMBB.Contains(EMKLHBIMGDN))
		{
			throw new ArgumentException(string.Format("[00AAFF]Location:[-] ", EMKLHBIMGDN));
		}
		this.PJPCIMJDMBB.Remove(EMKLHBIMGDN);
		RenderTexture.ReleaseTemporary(EMKLHBIMGDN);
	}

	// Token: 0x06006AB4 RID: 27316 RVA: 0x00349B90 File Offset: 0x00347D90
	public RenderTexture MLLNLFQCMKQ(int KJGMGPCEJJD, int DFKQMMIQDOO, int MBDMCBIEFMD = 0, RenderTextureFormat EIBOBKJIGQB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite OQMJFJDFJND = RenderTextureReadWrite.Default, FilterMode COONGPMDHLH = FilterMode.Bilinear, TextureWrapMode JPHMBHNQPNO = TextureWrapMode.Clamp, string IHIHHCCEDHQ = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, MBDMCBIEFMD, EIBOBKJIGQB, OQMJFJDFJND);
		temporary.filterMode = COONGPMDHLH;
		temporary.wrapMode = JPHMBHNQPNO;
		temporary.name = IHIHHCCEDHQ;
		this.PJPCIMJDMBB.Add(temporary);
		return temporary;
	}

	// Token: 0x06006AB5 RID: 27317 RVA: 0x00349BD0 File Offset: 0x00347DD0
	public void LFFJDMELCCI()
	{
		foreach (RenderTexture temp in this.PJPCIMJDMBB)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.PJPCIMJDMBB.Clear();
	}

	// Token: 0x06006AB6 RID: 27318 RVA: 0x00349BD0 File Offset: 0x00347DD0
	public void PIMHDLDBNGP()
	{
		foreach (RenderTexture temp in this.PJPCIMJDMBB)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.PJPCIMJDMBB.Clear();
	}

	// Token: 0x06006AB7 RID: 27319 RVA: 0x00028163 File Offset: 0x00026363
	public PIJIQKMKDPO()
	{
		this.PJPCIMJDMBB = new HashSet<RenderTexture>();
	}

	// Token: 0x06006AB8 RID: 27320 RVA: 0x00028176 File Offset: 0x00026376
	public void MKINKOCLEMQ()
	{
		this.LFFJDMELCCI();
	}

	// Token: 0x06006AB9 RID: 27321 RVA: 0x00349C0C File Offset: 0x00347E0C
	public RenderTexture DHLOEEOKKCL(RenderTexture EBGCIIFFMKF)
	{
		return this.FJNNLPBLMKQ(EBGCIIFFMKF.width, EBGCIIFFMKF.height, EBGCIIFFMKF.depth, EBGCIIFFMKF.format, (!EBGCIIFFMKF.sRGB) ? RenderTextureReadWrite.Linear : ((RenderTextureReadWrite)3), EBGCIIFFMKF.filterMode, EBGCIIFFMKF.wrapMode, "[-]");
	}

	// Token: 0x06006ABA RID: 27322 RVA: 0x00349BD0 File Offset: 0x00347DD0
	public void DJECKELDOFE()
	{
		foreach (RenderTexture temp in this.PJPCIMJDMBB)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.PJPCIMJDMBB.Clear();
	}

	// Token: 0x06006ABB RID: 27323 RVA: 0x0002817E File Offset: 0x0002637E
	public void LJFCOIKLHCF(RenderTexture EMKLHBIMGDN)
	{
		if (EMKLHBIMGDN == null)
		{
			return;
		}
		if (!this.PJPCIMJDMBB.Contains(EMKLHBIMGDN))
		{
			throw new ArgumentException(string.Format("_Rotation", EMKLHBIMGDN));
		}
		this.PJPCIMJDMBB.Remove(EMKLHBIMGDN);
		RenderTexture.ReleaseTemporary(EMKLHBIMGDN);
	}

	// Token: 0x06006ABC RID: 27324 RVA: 0x000281BC File Offset: 0x000263BC
	public void GPGCMDQLKQQ()
	{
		this.PIMHDLDBNGP();
	}

	// Token: 0x06006ABD RID: 27325 RVA: 0x00349BD0 File Offset: 0x00347DD0
	public void FMJFNIPHBCP()
	{
		foreach (RenderTexture temp in this.PJPCIMJDMBB)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.PJPCIMJDMBB.Clear();
	}

	// Token: 0x06006ABE RID: 27326 RVA: 0x00349C54 File Offset: 0x00347E54
	public RenderTexture INJNQNMOKKD(RenderTexture EBGCIIFFMKF)
	{
		return this.INJNQNMOKKD(EBGCIIFFMKF.width, EBGCIIFFMKF.height, EBGCIIFFMKF.depth, EBGCIIFFMKF.format, (!EBGCIIFFMKF.sRGB) ? RenderTextureReadWrite.Linear : RenderTextureReadWrite.sRGB, EBGCIIFFMKF.filterMode, EBGCIIFFMKF.wrapMode, "FactoryTempTexture");
	}

	// Token: 0x06006ABF RID: 27327 RVA: 0x00349B90 File Offset: 0x00347D90
	public RenderTexture DPJPPEPHPQN(int KJGMGPCEJJD, int DFKQMMIQDOO, int MBDMCBIEFMD = 0, RenderTextureFormat EIBOBKJIGQB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite OQMJFJDFJND = RenderTextureReadWrite.Default, FilterMode COONGPMDHLH = FilterMode.Bilinear, TextureWrapMode JPHMBHNQPNO = TextureWrapMode.Clamp, string IHIHHCCEDHQ = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, MBDMCBIEFMD, EIBOBKJIGQB, OQMJFJDFJND);
		temporary.filterMode = COONGPMDHLH;
		temporary.wrapMode = JPHMBHNQPNO;
		temporary.name = IHIHHCCEDHQ;
		this.PJPCIMJDMBB.Add(temporary);
		return temporary;
	}

	// Token: 0x06006AC0 RID: 27328 RVA: 0x00349BD0 File Offset: 0x00347DD0
	public void FMIBIDPFFQJ()
	{
		foreach (RenderTexture temp in this.PJPCIMJDMBB)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.PJPCIMJDMBB.Clear();
	}

	// Token: 0x06006AC1 RID: 27329 RVA: 0x000281C4 File Offset: 0x000263C4
	public void ICJLJEKEIJL(RenderTexture EMKLHBIMGDN)
	{
		if (EMKLHBIMGDN == null)
		{
			return;
		}
		if (!this.PJPCIMJDMBB.Contains(EMKLHBIMGDN))
		{
			throw new ArgumentException(string.Format(" must recharge!\r\n", EMKLHBIMGDN));
		}
		this.PJPCIMJDMBB.Remove(EMKLHBIMGDN);
		RenderTexture.ReleaseTemporary(EMKLHBIMGDN);
	}

	// Token: 0x06006AC2 RID: 27330 RVA: 0x00349B90 File Offset: 0x00347D90
	public RenderTexture FJNNLPBLMKQ(int KJGMGPCEJJD, int DFKQMMIQDOO, int MBDMCBIEFMD = 0, RenderTextureFormat EIBOBKJIGQB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite OQMJFJDFJND = RenderTextureReadWrite.Default, FilterMode COONGPMDHLH = FilterMode.Bilinear, TextureWrapMode JPHMBHNQPNO = TextureWrapMode.Clamp, string IHIHHCCEDHQ = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, MBDMCBIEFMD, EIBOBKJIGQB, OQMJFJDFJND);
		temporary.filterMode = COONGPMDHLH;
		temporary.wrapMode = JPHMBHNQPNO;
		temporary.name = IHIHHCCEDHQ;
		this.PJPCIMJDMBB.Add(temporary);
		return temporary;
	}

	// Token: 0x06006AC3 RID: 27331 RVA: 0x00028202 File Offset: 0x00026402
	public void ECGDGNFJPBO()
	{
		this.OHIKDMPKEBF();
	}

	// Token: 0x06006AC4 RID: 27332 RVA: 0x00349B90 File Offset: 0x00347D90
	public RenderTexture IKCIPBPOPMM(int KJGMGPCEJJD, int DFKQMMIQDOO, int MBDMCBIEFMD = 0, RenderTextureFormat EIBOBKJIGQB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite OQMJFJDFJND = RenderTextureReadWrite.Default, FilterMode COONGPMDHLH = FilterMode.Bilinear, TextureWrapMode JPHMBHNQPNO = TextureWrapMode.Clamp, string IHIHHCCEDHQ = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, MBDMCBIEFMD, EIBOBKJIGQB, OQMJFJDFJND);
		temporary.filterMode = COONGPMDHLH;
		temporary.wrapMode = JPHMBHNQPNO;
		temporary.name = IHIHHCCEDHQ;
		this.PJPCIMJDMBB.Add(temporary);
		return temporary;
	}

	// Token: 0x06006AC5 RID: 27333 RVA: 0x0002820A File Offset: 0x0002640A
	public void EIMIOQCIJKB(RenderTexture EMKLHBIMGDN)
	{
		if (EMKLHBIMGDN == null)
		{
			return;
		}
		if (!this.PJPCIMJDMBB.Contains(EMKLHBIMGDN))
		{
			throw new ArgumentException(string.Format("!\r\n", EMKLHBIMGDN));
		}
		this.PJPCIMJDMBB.Remove(EMKLHBIMGDN);
		RenderTexture.ReleaseTemporary(EMKLHBIMGDN);
	}

	// Token: 0x06006AC6 RID: 27334 RVA: 0x00349C9C File Offset: 0x00347E9C
	public RenderTexture OPMDBFNDEBD(RenderTexture EBGCIIFFMKF)
	{
		return this.DPJPPEPHPQN(EBGCIIFFMKF.width, EBGCIIFFMKF.height, EBGCIIFFMKF.depth, EBGCIIFFMKF.format, (!EBGCIIFFMKF.sRGB) ? RenderTextureReadWrite.Linear : ((RenderTextureReadWrite)3), EBGCIIFFMKF.filterMode, EBGCIIFFMKF.wrapMode, "Enter a Guild Name below to create a Guild.\nCost: [PG]1,000");
	}

	// Token: 0x06006AC7 RID: 27335 RVA: 0x00349CE4 File Offset: 0x00347EE4
	public RenderTexture BCKHMJFJMNP(RenderTexture EBGCIIFFMKF)
	{
		return this.QEFKHHIMDIQ(EBGCIIFFMKF.width, EBGCIIFFMKF.height, EBGCIIFFMKF.depth, EBGCIIFFMKF.format, (!EBGCIIFFMKF.sRGB) ? RenderTextureReadWrite.Linear : RenderTextureReadWrite.Default, EBGCIIFFMKF.filterMode, EBGCIIFFMKF.wrapMode, "It had no effect!\r\n");
	}

	// Token: 0x06006AC8 RID: 27336 RVA: 0x00028248 File Offset: 0x00026448
	public void DGMKGLLBMFG(RenderTexture EMKLHBIMGDN)
	{
		if (EMKLHBIMGDN == null)
		{
			return;
		}
		if (!this.PJPCIMJDMBB.Contains(EMKLHBIMGDN))
		{
			throw new ArgumentException(string.Format("Attempting to remove a RenderTexture that was not allocated: {0}", EMKLHBIMGDN));
		}
		this.PJPCIMJDMBB.Remove(EMKLHBIMGDN);
		RenderTexture.ReleaseTemporary(EMKLHBIMGDN);
	}

	// Token: 0x06006AC9 RID: 27337 RVA: 0x00349BD0 File Offset: 0x00347DD0
	public void FCBKNMEDHQE()
	{
		foreach (RenderTexture temp in this.PJPCIMJDMBB)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.PJPCIMJDMBB.Clear();
	}

	// Token: 0x06006ACA RID: 27338 RVA: 0x00028286 File Offset: 0x00026486
	public void Dispose()
	{
		this.ECKEBCJPIHE();
	}

	// Token: 0x06006ACB RID: 27339 RVA: 0x00349D2C File Offset: 0x00347F2C
	public RenderTexture ODOJHJGHDNO(RenderTexture EBGCIIFFMKF)
	{
		return this.JOLPMHHECLG(EBGCIIFFMKF.width, EBGCIIFFMKF.height, EBGCIIFFMKF.depth, EBGCIIFFMKF.format, (!EBGCIIFFMKF.sRGB) ? RenderTextureReadWrite.Linear : RenderTextureReadWrite.Linear, EBGCIIFFMKF.filterMode, EBGCIIFFMKF.wrapMode, "_Male");
	}

	// Token: 0x06006ACC RID: 27340 RVA: 0x0002828E File Offset: 0x0002648E
	public void MEBDHMGLMEN(RenderTexture EMKLHBIMGDN)
	{
		if (EMKLHBIMGDN == null)
		{
			return;
		}
		if (!this.PJPCIMJDMBB.Contains(EMKLHBIMGDN))
		{
			throw new ArgumentException(string.Format("7fff49", EMKLHBIMGDN));
		}
		this.PJPCIMJDMBB.Remove(EMKLHBIMGDN);
		RenderTexture.ReleaseTemporary(EMKLHBIMGDN);
	}

	// Token: 0x06006ACD RID: 27341 RVA: 0x00349BD0 File Offset: 0x00347DD0
	public void OHIKDMPKEBF()
	{
		foreach (RenderTexture temp in this.PJPCIMJDMBB)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.PJPCIMJDMBB.Clear();
	}

	// Token: 0x06006ACE RID: 27342 RVA: 0x00349B90 File Offset: 0x00347D90
	public RenderTexture DNOMDLFEKHP(int KJGMGPCEJJD, int DFKQMMIQDOO, int MBDMCBIEFMD = 0, RenderTextureFormat EIBOBKJIGQB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite OQMJFJDFJND = RenderTextureReadWrite.Default, FilterMode COONGPMDHLH = FilterMode.Bilinear, TextureWrapMode JPHMBHNQPNO = TextureWrapMode.Clamp, string IHIHHCCEDHQ = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, MBDMCBIEFMD, EIBOBKJIGQB, OQMJFJDFJND);
		temporary.filterMode = COONGPMDHLH;
		temporary.wrapMode = JPHMBHNQPNO;
		temporary.name = IHIHHCCEDHQ;
		this.PJPCIMJDMBB.Add(temporary);
		return temporary;
	}

	// Token: 0x06006ACF RID: 27343 RVA: 0x00028176 File Offset: 0x00026376
	public void FOOBEJQGFDM()
	{
		this.LFFJDMELCCI();
	}

	// Token: 0x06006AD0 RID: 27344 RVA: 0x00349D74 File Offset: 0x00347F74
	public RenderTexture DNKGKNNMFBC(RenderTexture EBGCIIFFMKF)
	{
		return this.DNOMDLFEKHP(EBGCIIFFMKF.width, EBGCIIFFMKF.height, EBGCIIFFMKF.depth, EBGCIIFFMKF.format, (!EBGCIIFFMKF.sRGB) ? RenderTextureReadWrite.Linear : RenderTextureReadWrite.Default, EBGCIIFFMKF.filterMode, EBGCIIFFMKF.wrapMode, "[-]'s team won the battle!\r\n");
	}

	// Token: 0x06006AD1 RID: 27345 RVA: 0x00028176 File Offset: 0x00026376
	public void PGBJGIEMIJJ()
	{
		this.LFFJDMELCCI();
	}

	// Token: 0x06006AD2 RID: 27346 RVA: 0x000282CC File Offset: 0x000264CC
	public void NJEHMLKGJHG()
	{
		this.FCBKNMEDHQE();
	}

	// Token: 0x06006AD3 RID: 27347 RVA: 0x00349B90 File Offset: 0x00347D90
	public RenderTexture INJNQNMOKKD(int KJGMGPCEJJD, int DFKQMMIQDOO, int MBDMCBIEFMD = 0, RenderTextureFormat EIBOBKJIGQB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite OQMJFJDFJND = RenderTextureReadWrite.Default, FilterMode COONGPMDHLH = FilterMode.Bilinear, TextureWrapMode JPHMBHNQPNO = TextureWrapMode.Clamp, string IHIHHCCEDHQ = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, MBDMCBIEFMD, EIBOBKJIGQB, OQMJFJDFJND);
		temporary.filterMode = COONGPMDHLH;
		temporary.wrapMode = JPHMBHNQPNO;
		temporary.name = IHIHHCCEDHQ;
		this.PJPCIMJDMBB.Add(temporary);
		return temporary;
	}

	// Token: 0x06006AD4 RID: 27348 RVA: 0x00349B90 File Offset: 0x00347D90
	public RenderTexture QEFKHHIMDIQ(int KJGMGPCEJJD, int DFKQMMIQDOO, int MBDMCBIEFMD = 0, RenderTextureFormat EIBOBKJIGQB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite OQMJFJDFJND = RenderTextureReadWrite.Default, FilterMode COONGPMDHLH = FilterMode.Bilinear, TextureWrapMode JPHMBHNQPNO = TextureWrapMode.Clamp, string IHIHHCCEDHQ = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, MBDMCBIEFMD, EIBOBKJIGQB, OQMJFJDFJND);
		temporary.filterMode = COONGPMDHLH;
		temporary.wrapMode = JPHMBHNQPNO;
		temporary.name = IHIHHCCEDHQ;
		this.PJPCIMJDMBB.Add(temporary);
		return temporary;
	}

	// Token: 0x06006AD5 RID: 27349 RVA: 0x000282D4 File Offset: 0x000264D4
	public void PJQOLKDCNOD()
	{
		this.FMJFNIPHBCP();
	}

	// Token: 0x06006AD6 RID: 27350 RVA: 0x000282D4 File Offset: 0x000264D4
	public void KPIBGJBMEBN()
	{
		this.FMJFNIPHBCP();
	}

	// Token: 0x06006AD7 RID: 27351 RVA: 0x000282DC File Offset: 0x000264DC
	public void HEJBQLMOONQ()
	{
		this.DNGNEKGFEMI();
	}

	// Token: 0x06006AD8 RID: 27352 RVA: 0x000281BC File Offset: 0x000263BC
	public void BLDFLEPOHQG()
	{
		this.PIMHDLDBNGP();
	}

	// Token: 0x06006AD9 RID: 27353 RVA: 0x00349BD0 File Offset: 0x00347DD0
	public void ECKEBCJPIHE()
	{
		foreach (RenderTexture temp in this.PJPCIMJDMBB)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.PJPCIMJDMBB.Clear();
	}

	// Token: 0x06006ADA RID: 27354 RVA: 0x00349BD0 File Offset: 0x00347DD0
	public void DNGNEKGFEMI()
	{
		foreach (RenderTexture temp in this.PJPCIMJDMBB)
		{
			RenderTexture.ReleaseTemporary(temp);
		}
		this.PJPCIMJDMBB.Clear();
	}

	// Token: 0x06006ADB RID: 27355 RVA: 0x00349B90 File Offset: 0x00347D90
	public RenderTexture JOLPMHHECLG(int KJGMGPCEJJD, int DFKQMMIQDOO, int MBDMCBIEFMD = 0, RenderTextureFormat EIBOBKJIGQB = RenderTextureFormat.ARGBHalf, RenderTextureReadWrite OQMJFJDFJND = RenderTextureReadWrite.Default, FilterMode COONGPMDHLH = FilterMode.Bilinear, TextureWrapMode JPHMBHNQPNO = TextureWrapMode.Clamp, string IHIHHCCEDHQ = "FactoryTempTexture")
	{
		RenderTexture temporary = RenderTexture.GetTemporary(KJGMGPCEJJD, DFKQMMIQDOO, MBDMCBIEFMD, EIBOBKJIGQB, OQMJFJDFJND);
		temporary.filterMode = COONGPMDHLH;
		temporary.wrapMode = JPHMBHNQPNO;
		temporary.name = IHIHHCCEDHQ;
		this.PJPCIMJDMBB.Add(temporary);
		return temporary;
	}

	// Token: 0x0400167B RID: 5755
	private HashSet<RenderTexture> PJPCIMJDMBB;
}
