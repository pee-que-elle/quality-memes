using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200018F RID: 399
[AddComponentMenu("NGUI/UI/Sprite Animation")]
[ExecuteInEditMode]
public class KKPFGFEEGOM : MonoBehaviour
{
	// Token: 0x060031A1 RID: 12705 RVA: 0x000162C3 File Offset: 0x000144C3
	public void BLCOLLBJFNC(string BGBMIEJJQKC)
	{
		if (this.mPrefix != BGBMIEJJQKC)
		{
			this.mPrefix = BGBMIEJJQKC;
			this.HHJOHDCNEFJ();
		}
	}

	// Token: 0x060031A2 RID: 12706 RVA: 0x000162E0 File Offset: 0x000144E0
	public bool EKMCJJKLLHK()
	{
		return this.EDBBMFGOGHO;
	}

	// Token: 0x060031A3 RID: 12707 RVA: 0x000162E8 File Offset: 0x000144E8
	public string JEFKMJHGEIN()
	{
		return this.mPrefix;
	}

	// Token: 0x060031A4 RID: 12708 RVA: 0x000162F0 File Offset: 0x000144F0
	public void DNMDCCILGIM(int BGBMIEJJQKC)
	{
		this.mFPS = BGBMIEJJQKC;
	}

	// Token: 0x1700022C RID: 556
	// (get) Token: 0x060031A5 RID: 12709 RVA: 0x000162E0 File Offset: 0x000144E0
	public bool BPBPHLQGEBM
	{
		get
		{
			return this.EDBBMFGOGHO;
		}
	}

	// Token: 0x060031A6 RID: 12710 RVA: 0x000162F9 File Offset: 0x000144F9
	public bool GEMBJQCCHNM()
	{
		return this.mLoop;
	}

	// Token: 0x17000227 RID: 551
	// (get) Token: 0x060031A7 RID: 12711 RVA: 0x000162E8 File Offset: 0x000144E8
	// (set) Token: 0x060031C4 RID: 12740 RVA: 0x000163A2 File Offset: 0x000145A2
	public string LINEBMQLLPI
	{
		get
		{
			return this.mPrefix;
		}
		set
		{
			if (this.mPrefix != value)
			{
				this.mPrefix = value;
				this.HQPMGPHJBNH();
			}
		}
	}

	// Token: 0x17000226 RID: 550
	// (get) Token: 0x060031BA RID: 12730 RVA: 0x00016325 File Offset: 0x00014525
	// (set) Token: 0x060031A8 RID: 12712 RVA: 0x000162F0 File Offset: 0x000144F0
	public int OJBHDMENDDH
	{
		get
		{
			return this.mFPS;
		}
		set
		{
			this.mFPS = value;
		}
	}

	// Token: 0x060031A9 RID: 12713 RVA: 0x00016301 File Offset: 0x00014501
	public void MINQQGOGNGB(bool BGBMIEJJQKC)
	{
		this.QOMMDHHIKLG = BGBMIEJJQKC;
		this.EBODEFGJIQC();
	}

	// Token: 0x060031AA RID: 12714 RVA: 0x000162E8 File Offset: 0x000144E8
	public string INBOIDQJOQN()
	{
		return this.mPrefix;
	}

	// Token: 0x060031AB RID: 12715 RVA: 0x00016310 File Offset: 0x00014510
	private void Start()
	{
		this.HQPMGPHJBNH();
	}

	// Token: 0x060031AC RID: 12716 RVA: 0x00016318 File Offset: 0x00014518
	public int MEMKMJBCFQG()
	{
		return this.BBIOOOFLMCD.Count;
	}

	// Token: 0x060031AD RID: 12717 RVA: 0x000162E0 File Offset: 0x000144E0
	public bool NPQDDKNNLKK()
	{
		return this.EDBBMFGOGHO;
	}

	// Token: 0x060031AE RID: 12718 RVA: 0x00175004 File Offset: 0x00173204
	public void MEGGNILIHIN()
	{
		this.EDBBMFGOGHO = false;
		this.LOOPGMJNQBQ = 1;
		if (this.BLLEFKOLKLP == null)
		{
			this.BLLEFKOLKLP = base.GetComponent<Transform>();
		}
		if (this.BBIOOOFLMCD != null && this.BBIOOOFLMCD.Count > 1)
		{
			List<Vector2> list = new List<Vector2>();
			float num = 1059f / (float)this.QKGJDCFCPMO.JGMFILNPFLH.width;
			float num2 = 1975f / (float)this.QKGJDCFCPMO.JGMFILNPFLH.height;
			UISpriteData uispriteData = this.QKGJDCFCPMO.GMEDHEOGFMB(this.BBIOOOFLMCD[0]);
			float x = num * (float)uispriteData.x;
			float x2 = num * ((float)uispriteData.x + (float)uispriteData.width);
			float num3 = num2 * (float)uispriteData.y;
			float num4 = num2 * ((float)uispriteData.y + (float)uispriteData.height);
			list.Add(new Vector2(x, 600f - num3));
			list.Add(new Vector2(x2, 243f - num4));
			list.Add(new Vector2(x2, 908f - num3));
			list.Add(new Vector2(x, 77f - num4));
			this.CDCKPFJQDKN.mesh.SetUVs(0, list);
			float num5 = 1507f;
			this.BLLEFKOLKLP.localScale = new Vector3((float)uispriteData.width * num5, (float)uispriteData.height * num5, 433f);
		}
	}

	// Token: 0x060031AF RID: 12719 RVA: 0x00016325 File Offset: 0x00014525
	public int KLEEMBKCPLN()
	{
		return this.mFPS;
	}

	// Token: 0x060031B0 RID: 12720 RVA: 0x00175178 File Offset: 0x00173378
	private void EBODEFGJIQC()
	{
		if (this.CDCKPFJQDKN == null)
		{
			this.CDCKPFJQDKN = base.GetComponent<MeshFilter>();
		}
		this.BBIOOOFLMCD.Clear();
		if (this.QKGJDCFCPMO != null)
		{
			base.GetComponent<MeshRenderer>().material.mainTexture = this.QKGJDCFCPMO.JGMFILNPFLH;
			List<UISpriteData> ildjpqcfifh = this.QKGJDCFCPMO.ILDJPQCFIFH;
			int i = 1;
			int count = ildjpqcfifh.Count;
			while (i < count)
			{
				UISpriteData uispriteData = ildjpqcfifh[i];
				if (string.IsNullOrEmpty(this.mPrefix) || uispriteData.name.StartsWith(this.mPrefix))
				{
					this.BBIOOOFLMCD.Add(uispriteData.name);
				}
				i++;
			}
			this.BBIOOOFLMCD.Sort();
			if (this.QOMMDHHIKLG)
			{
				this.BBIOOOFLMCD.Reverse();
			}
		}
	}

	// Token: 0x17000229 RID: 553
	// (get) Token: 0x060031B1 RID: 12721 RVA: 0x0001632D File Offset: 0x0001452D
	// (set) Token: 0x060031DA RID: 12762 RVA: 0x00175D98 File Offset: 0x00173F98
	public float FQDKBPJIDMM
	{
		get
		{
			return this.PNQCIOILOJF;
		}
		set
		{
			this.PNQCIOILOJF = value;
			if (this.BLLEFKOLKLP != null)
			{
				UISpriteData uispriteData = this.QKGJDCFCPMO.GMEDHEOGFMB(this.BBIOOOFLMCD[this.LOOPGMJNQBQ]);
				float num = 0.2f;
				this.BLLEFKOLKLP.localScale = new Vector3((float)uispriteData.width * num, (float)uispriteData.height * num, 1f);
			}
		}
	}

	// Token: 0x060031B2 RID: 12722 RVA: 0x00016325 File Offset: 0x00014525
	public int EFOCGOHLMLC()
	{
		return this.mFPS;
	}

	// Token: 0x1700022B RID: 555
	// (get) Token: 0x060031B3 RID: 12723 RVA: 0x000162F9 File Offset: 0x000144F9
	// (set) Token: 0x060031D8 RID: 12760 RVA: 0x000163BF File Offset: 0x000145BF
	public bool JHEEBKGBMPJ
	{
		get
		{
			return this.mLoop;
		}
		set
		{
			this.mLoop = value;
		}
	}

	// Token: 0x060031B4 RID: 12724 RVA: 0x0017524C File Offset: 0x0017344C
	private void HQPMGPHJBNH()
	{
		if (this.CDCKPFJQDKN == null)
		{
			this.CDCKPFJQDKN = base.GetComponent<MeshFilter>();
		}
		this.BBIOOOFLMCD.Clear();
		if (this.QKGJDCFCPMO != null)
		{
			base.GetComponent<MeshRenderer>().material.mainTexture = this.QKGJDCFCPMO.JGMFILNPFLH;
			List<UISpriteData> ildjpqcfifh = this.QKGJDCFCPMO.ILDJPQCFIFH;
			int i = 0;
			int count = ildjpqcfifh.Count;
			while (i < count)
			{
				UISpriteData uispriteData = ildjpqcfifh[i];
				if (string.IsNullOrEmpty(this.mPrefix) || uispriteData.name.StartsWith(this.mPrefix))
				{
					this.BBIOOOFLMCD.Add(uispriteData.name);
				}
				i++;
			}
			this.BBIOOOFLMCD.Sort();
			if (this.QOMMDHHIKLG)
			{
				this.BBIOOOFLMCD.Reverse();
			}
		}
	}

	// Token: 0x060031B5 RID: 12725 RVA: 0x00016318 File Offset: 0x00014518
	public int DMPQDNGPMEE()
	{
		return this.BBIOOOFLMCD.Count;
	}

	// Token: 0x060031B6 RID: 12726 RVA: 0x00016335 File Offset: 0x00014535
	public void BGGDBKBBQCJ(bool BGBMIEJJQKC)
	{
		this.QOMMDHHIKLG = BGBMIEJJQKC;
		this.HHJOHDCNEFJ();
	}

	// Token: 0x17000228 RID: 552
	// (get) Token: 0x060031D7 RID: 12759 RVA: 0x00016353 File Offset: 0x00014553
	// (set) Token: 0x060031B7 RID: 12727 RVA: 0x00016344 File Offset: 0x00014544
	public bool JPNKJKDFBML
	{
		get
		{
			return this.QOMMDHHIKLG;
		}
		set
		{
			this.QOMMDHHIKLG = value;
			this.HQPMGPHJBNH();
		}
	}

	// Token: 0x060031B8 RID: 12728 RVA: 0x00016353 File Offset: 0x00014553
	public bool MCBLFJFIEKG()
	{
		return this.QOMMDHHIKLG;
	}

	// Token: 0x060031B9 RID: 12729 RVA: 0x00175320 File Offset: 0x00173520
	private void Update()
	{
		if (this.CDCKPFJQDKN == null)
		{
			return;
		}
		if (this.EDBBMFGOGHO && this.BBIOOOFLMCD.Count > 1 && Application.isPlaying && (float)this.mFPS > 0f)
		{
			this.OFFPDBOKOQE += Time.deltaTime;
			float num = 1f / (float)this.mFPS;
			if (num < this.OFFPDBOKOQE)
			{
				this.OFFPDBOKOQE = ((num <= 0f) ? 0f : (this.OFFPDBOKOQE - num));
				if (++this.LOOPGMJNQBQ >= this.BBIOOOFLMCD.Count)
				{
					this.LOOPGMJNQBQ = 0;
					this.EDBBMFGOGHO = this.JHEEBKGBMPJ;
				}
				if (this.EDBBMFGOGHO)
				{
					List<Vector2> list = new List<Vector2>();
					float num2 = 1f / (float)this.QKGJDCFCPMO.JGMFILNPFLH.width;
					float num3 = 1f / (float)this.QKGJDCFCPMO.JGMFILNPFLH.height;
					UISpriteData uispriteData = this.QKGJDCFCPMO.GMEDHEOGFMB(this.BBIOOOFLMCD[this.LOOPGMJNQBQ]);
					float x = num2 * (float)uispriteData.x;
					float x2 = num2 * ((float)uispriteData.x + (float)uispriteData.width);
					float num4 = num3 * (float)uispriteData.y;
					float num5 = num3 * ((float)uispriteData.y + (float)uispriteData.height);
					list.Add(new Vector2(x, 1f - num4));
					list.Add(new Vector2(x2, 1f - num5));
					list.Add(new Vector2(x2, 1f - num4));
					list.Add(new Vector2(x, 1f - num5));
					this.CDCKPFJQDKN.mesh.SetUVs(0, list);
					float num6 = 0.015625f;
					this.BLLEFKOLKLP.localScale = new Vector3((float)uispriteData.width * num6, (float)uispriteData.height * num6, 1f);
				}
			}
		}
	}

	// Token: 0x060031BB RID: 12731 RVA: 0x0001632D File Offset: 0x0001452D
	public float OHFFDBGJBKQ()
	{
		return this.PNQCIOILOJF;
	}

	// Token: 0x060031BC RID: 12732 RVA: 0x0017552C File Offset: 0x0017372C
	private void IPFJMEFKGGM()
	{
		if (this.CDCKPFJQDKN == null)
		{
			return;
		}
		if (this.EDBBMFGOGHO && this.BBIOOOFLMCD.Count > 1 && Application.isPlaying && (float)this.mFPS > 1074f)
		{
			this.OFFPDBOKOQE += Time.deltaTime;
			float num = 1441f / (float)this.mFPS;
			if (num < this.OFFPDBOKOQE)
			{
				this.OFFPDBOKOQE = ((num <= 467f) ? 1781f : (this.OFFPDBOKOQE - num));
				if (++this.LOOPGMJNQBQ >= this.BBIOOOFLMCD.Count)
				{
					this.LOOPGMJNQBQ = 0;
					this.EDBBMFGOGHO = this.ENMMPGPPKEQ();
				}
				if (this.EDBBMFGOGHO)
				{
					List<Vector2> list = new List<Vector2>();
					float num2 = 63f / (float)this.QKGJDCFCPMO.JGMFILNPFLH.width;
					float num3 = 535f / (float)this.QKGJDCFCPMO.JGMFILNPFLH.height;
					UISpriteData uispriteData = this.QKGJDCFCPMO.KPQNNOJJKDO(this.BBIOOOFLMCD[this.LOOPGMJNQBQ]);
					float x = num2 * (float)uispriteData.x;
					float x2 = num2 * ((float)uispriteData.x + (float)uispriteData.width);
					float num4 = num3 * (float)uispriteData.y;
					float num5 = num3 * ((float)uispriteData.y + (float)uispriteData.height);
					list.Add(new Vector2(x, 660f - num4));
					list.Add(new Vector2(x2, 1475f - num5));
					list.Add(new Vector2(x2, 249f - num4));
					list.Add(new Vector2(x, 374f - num5));
					this.CDCKPFJQDKN.mesh.SetUVs(0, list);
					float num6 = 911f;
					this.BLLEFKOLKLP.localScale = new Vector3((float)uispriteData.width * num6, (float)uispriteData.height * num6, 778f);
				}
			}
		}
	}

	// Token: 0x1700022A RID: 554
	// (get) Token: 0x060031BD RID: 12733 RVA: 0x0001635B File Offset: 0x0001455B
	public List<string> MLIFQHMLDFJ
	{
		get
		{
			return this.BBIOOOFLMCD;
		}
	}

	// Token: 0x060031BE RID: 12734 RVA: 0x000162E8 File Offset: 0x000144E8
	public string LNLEKPBHMOM()
	{
		return this.mPrefix;
	}

	// Token: 0x060031C0 RID: 12736 RVA: 0x000162F0 File Offset: 0x000144F0
	public void CIJLLIHDQJQ(int BGBMIEJJQKC)
	{
		this.mFPS = BGBMIEJJQKC;
	}

	// Token: 0x060031C1 RID: 12737 RVA: 0x00016318 File Offset: 0x00014518
	public int MGGIPCLKLGD()
	{
		return this.BBIOOOFLMCD.Count;
	}

	// Token: 0x060031C2 RID: 12738 RVA: 0x0001632D File Offset: 0x0001452D
	public float EPGCFJOGQFQ()
	{
		return this.PNQCIOILOJF;
	}

	// Token: 0x060031C3 RID: 12739 RVA: 0x00016335 File Offset: 0x00014535
	public void HLGGEHEMNEO(bool BGBMIEJJQKC)
	{
		this.QOMMDHHIKLG = BGBMIEJJQKC;
		this.HHJOHDCNEFJ();
	}

	// Token: 0x060031C5 RID: 12741 RVA: 0x00175738 File Offset: 0x00173938
	private void QDIKKLMCIJK()
	{
		if (this.CDCKPFJQDKN == null)
		{
			return;
		}
		if (this.EDBBMFGOGHO && this.BBIOOOFLMCD.Count > 1 && Application.isPlaying && (float)this.mFPS > 165f)
		{
			this.OFFPDBOKOQE += Time.deltaTime;
			float num = 58f / (float)this.mFPS;
			if (num < this.OFFPDBOKOQE)
			{
				this.OFFPDBOKOQE = ((num <= 890f) ? 1528f : (this.OFFPDBOKOQE - num));
				if ((this.LOOPGMJNQBQ += 0) >= this.BBIOOOFLMCD.Count)
				{
					this.LOOPGMJNQBQ = 1;
					this.EDBBMFGOGHO = this.GEMBJQCCHNM();
				}
				if (this.EDBBMFGOGHO)
				{
					List<Vector2> list = new List<Vector2>();
					float num2 = 1453f / (float)this.QKGJDCFCPMO.JGMFILNPFLH.width;
					float num3 = 331f / (float)this.QKGJDCFCPMO.JGMFILNPFLH.height;
					UISpriteData uispriteData = this.QKGJDCFCPMO.KPQNNOJJKDO(this.BBIOOOFLMCD[this.LOOPGMJNQBQ]);
					float x = num2 * (float)uispriteData.x;
					float x2 = num2 * ((float)uispriteData.x + (float)uispriteData.width);
					float num4 = num3 * (float)uispriteData.y;
					float num5 = num3 * ((float)uispriteData.y + (float)uispriteData.height);
					list.Add(new Vector2(x, 15f - num4));
					list.Add(new Vector2(x2, 1636f - num5));
					list.Add(new Vector2(x2, 1026f - num4));
					list.Add(new Vector2(x, 428f - num5));
					this.CDCKPFJQDKN.mesh.SetUVs(0, list);
					float num6 = 1462f;
					this.BLLEFKOLKLP.localScale = new Vector3((float)uispriteData.width * num6, (float)uispriteData.height * num6, 965f);
				}
			}
		}
	}

	// Token: 0x17000225 RID: 549
	// (get) Token: 0x060031C6 RID: 12742 RVA: 0x00016318 File Offset: 0x00014518
	public int DIHDBMHGBHO
	{
		get
		{
			return this.BBIOOOFLMCD.Count;
		}
	}

	// Token: 0x060031C7 RID: 12743 RVA: 0x000162F0 File Offset: 0x000144F0
	public void IKNQOIQDNGN(int BGBMIEJJQKC)
	{
		this.mFPS = BGBMIEJJQKC;
	}

	// Token: 0x060031C8 RID: 12744 RVA: 0x00016353 File Offset: 0x00014553
	public bool QOGKKNMFBMK()
	{
		return this.QOMMDHHIKLG;
	}

	// Token: 0x060031C9 RID: 12745 RVA: 0x00175944 File Offset: 0x00173B44
	private void HHJOHDCNEFJ()
	{
		if (this.CDCKPFJQDKN == null)
		{
			this.CDCKPFJQDKN = base.GetComponent<MeshFilter>();
		}
		this.BBIOOOFLMCD.Clear();
		if (this.QKGJDCFCPMO != null)
		{
			base.GetComponent<MeshRenderer>().material.mainTexture = this.QKGJDCFCPMO.JGMFILNPFLH;
			List<UISpriteData> ildjpqcfifh = this.QKGJDCFCPMO.ILDJPQCFIFH;
			int i = 0;
			int count = ildjpqcfifh.Count;
			while (i < count)
			{
				UISpriteData uispriteData = ildjpqcfifh[i];
				if (string.IsNullOrEmpty(this.mPrefix) || uispriteData.name.StartsWith(this.mPrefix))
				{
					this.BBIOOOFLMCD.Add(uispriteData.name);
				}
				i += 0;
			}
			this.BBIOOOFLMCD.Sort();
			if (this.QOMMDHHIKLG)
			{
				this.BBIOOOFLMCD.Reverse();
			}
		}
	}

	// Token: 0x060031CA RID: 12746 RVA: 0x000162E0 File Offset: 0x000144E0
	public bool MQLNBNNFEFI()
	{
		return this.EDBBMFGOGHO;
	}

	// Token: 0x060031CB RID: 12747 RVA: 0x000163BF File Offset: 0x000145BF
	public void JEEJJLQFJND(bool BGBMIEJJQKC)
	{
		this.mLoop = BGBMIEJJQKC;
	}

	// Token: 0x060031CC RID: 12748 RVA: 0x00175A18 File Offset: 0x00173C18
	private void IGJKHIMGLFH()
	{
		if (this.CDCKPFJQDKN == null)
		{
			return;
		}
		if (this.EDBBMFGOGHO && this.BBIOOOFLMCD.Count > 1 && Application.isPlaying && (float)this.mFPS > 489f)
		{
			this.OFFPDBOKOQE += Time.deltaTime;
			float num = 1146f / (float)this.mFPS;
			if (num < this.OFFPDBOKOQE)
			{
				this.OFFPDBOKOQE = ((num <= 1845f) ? 655f : (this.OFFPDBOKOQE - num));
				if ((this.LOOPGMJNQBQ += 0) >= this.BBIOOOFLMCD.Count)
				{
					this.LOOPGMJNQBQ = 1;
					this.EDBBMFGOGHO = this.QIPKLBHFFEL();
				}
				if (this.EDBBMFGOGHO)
				{
					List<Vector2> list = new List<Vector2>();
					float num2 = 777f / (float)this.QKGJDCFCPMO.JGMFILNPFLH.width;
					float num3 = 1292f / (float)this.QKGJDCFCPMO.JGMFILNPFLH.height;
					UISpriteData uispriteData = this.QKGJDCFCPMO.KPQNNOJJKDO(this.BBIOOOFLMCD[this.LOOPGMJNQBQ]);
					float x = num2 * (float)uispriteData.x;
					float x2 = num2 * ((float)uispriteData.x + (float)uispriteData.width);
					float num4 = num3 * (float)uispriteData.y;
					float num5 = num3 * ((float)uispriteData.y + (float)uispriteData.height);
					list.Add(new Vector2(x, 1664f - num4));
					list.Add(new Vector2(x2, 248f - num5));
					list.Add(new Vector2(x2, 1093f - num4));
					list.Add(new Vector2(x, 1758f - num5));
					this.CDCKPFJQDKN.mesh.SetUVs(1, list);
					float num6 = 100f;
					this.BLLEFKOLKLP.localScale = new Vector3((float)uispriteData.width * num6, (float)uispriteData.height * num6, 1870f);
				}
			}
		}
	}

	// Token: 0x060031CD RID: 12749 RVA: 0x00175C24 File Offset: 0x00173E24
	public void Reset()
	{
		this.EDBBMFGOGHO = true;
		this.LOOPGMJNQBQ = 0;
		if (this.BLLEFKOLKLP == null)
		{
			this.BLLEFKOLKLP = base.GetComponent<Transform>();
		}
		if (this.BBIOOOFLMCD != null && this.BBIOOOFLMCD.Count > 0)
		{
			List<Vector2> list = new List<Vector2>();
			float num = 1f / (float)this.QKGJDCFCPMO.JGMFILNPFLH.width;
			float num2 = 1f / (float)this.QKGJDCFCPMO.JGMFILNPFLH.height;
			UISpriteData uispriteData = this.QKGJDCFCPMO.GMEDHEOGFMB(this.BBIOOOFLMCD[0]);
			float x = num * (float)uispriteData.x;
			float x2 = num * ((float)uispriteData.x + (float)uispriteData.width);
			float num3 = num2 * (float)uispriteData.y;
			float num4 = num2 * ((float)uispriteData.y + (float)uispriteData.height);
			list.Add(new Vector2(x, 1f - num3));
			list.Add(new Vector2(x2, 1f - num4));
			list.Add(new Vector2(x2, 1f - num3));
			list.Add(new Vector2(x, 1f - num4));
			this.CDCKPFJQDKN.mesh.SetUVs(0, list);
			float num5 = 0.0078125f;
			this.BLLEFKOLKLP.localScale = new Vector3((float)uispriteData.width * num5, (float)uispriteData.height * num5, 1f);
		}
	}

	// Token: 0x060031CE RID: 12750 RVA: 0x0001632D File Offset: 0x0001452D
	public float IFHJIODOGJE()
	{
		return this.PNQCIOILOJF;
	}

	// Token: 0x060031CF RID: 12751 RVA: 0x0001635B File Offset: 0x0001455B
	public List<string> EBICNDCFMMQ()
	{
		return this.BBIOOOFLMCD;
	}

	// Token: 0x060031D0 RID: 12752 RVA: 0x000162F9 File Offset: 0x000144F9
	public bool OFMOBPQNCJO()
	{
		return this.mLoop;
	}

	// Token: 0x060031D1 RID: 12753 RVA: 0x000163BF File Offset: 0x000145BF
	public void GQCJEHDHKGP(bool BGBMIEJJQKC)
	{
		this.mLoop = BGBMIEJJQKC;
	}

	// Token: 0x060031D2 RID: 12754 RVA: 0x000162F9 File Offset: 0x000144F9
	public bool QIPKLBHFFEL()
	{
		return this.mLoop;
	}

	// Token: 0x060031D3 RID: 12755 RVA: 0x00016353 File Offset: 0x00014553
	public bool IOFPQMDDHMI()
	{
		return this.QOMMDHHIKLG;
	}

	// Token: 0x060031D4 RID: 12756 RVA: 0x00016353 File Offset: 0x00014553
	public bool MGDBIDPQFBK()
	{
		return this.QOMMDHHIKLG;
	}

	// Token: 0x060031D5 RID: 12757 RVA: 0x000163C8 File Offset: 0x000145C8
	private void FCOIMQGENDB()
	{
		this.HHJOHDCNEFJ();
	}

	// Token: 0x060031D6 RID: 12758 RVA: 0x0001635B File Offset: 0x0001455B
	public List<string> HNLEQBGNKNI()
	{
		return this.BBIOOOFLMCD;
	}

	// Token: 0x060031D9 RID: 12761 RVA: 0x00016318 File Offset: 0x00014518
	public int JPEELMFEDHQ()
	{
		return this.BBIOOOFLMCD.Count;
	}

	// Token: 0x060031DB RID: 12763 RVA: 0x00016353 File Offset: 0x00014553
	public bool IJLNLBPQNIL()
	{
		return this.QOMMDHHIKLG;
	}

	// Token: 0x060031DC RID: 12764 RVA: 0x000162F9 File Offset: 0x000144F9
	public bool ENMMPGPPKEQ()
	{
		return this.mLoop;
	}

	// Token: 0x04000B82 RID: 2946
	[HideInInspector]
	[SerializeField]
	private int mFPS = 30;

	// Token: 0x04000B83 RID: 2947
	[SerializeField]
	[HideInInspector]
	private string mPrefix = string.Empty;

	// Token: 0x04000B84 RID: 2948
	[SerializeField]
	[HideInInspector]
	private bool mLoop = true;

	// Token: 0x04000B85 RID: 2949
	private MeshFilter CDCKPFJQDKN;

	// Token: 0x04000B86 RID: 2950
	private Transform BLLEFKOLKLP;

	// Token: 0x04000B87 RID: 2951
	public BPLKJMJMHFI QKGJDCFCPMO;

	// Token: 0x04000B88 RID: 2952
	private float OFFPDBOKOQE;

	// Token: 0x04000B89 RID: 2953
	private int LOOPGMJNQBQ;

	// Token: 0x04000B8A RID: 2954
	private bool EDBBMFGOGHO = true;

	// Token: 0x04000B8B RID: 2955
	private List<string> BBIOOOFLMCD = new List<string>();

	// Token: 0x04000B8C RID: 2956
	private bool QOMMDHHIKLG;

	// Token: 0x04000B8D RID: 2957
	private float PNQCIOILOJF = 1f;
}
