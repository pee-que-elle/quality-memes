using System;

// Token: 0x02000123 RID: 291
[Serializable]
public class UISpriteData
{
	// Token: 0x060021A8 RID: 8616 RVA: 0x00012115 File Offset: 0x00010315
	public void OMMLOPIGCKD(int DEQIFCDFMDK, int FPIPDOBGBQH, int JKDFCPKCQJP, int FNKCEOPHHKL)
	{
		this.borderLeft = DEQIFCDFMDK;
		this.borderBottom = FPIPDOBGBQH;
		this.borderRight = JKDFCPKCQJP;
		this.borderTop = FNKCEOPHHKL;
	}

	// Token: 0x060021A9 RID: 8617 RVA: 0x000D9F6C File Offset: 0x000D816C
	public void KDHJDBIEGPB(UISpriteData NOHQIKIJEQB)
	{
		this.name = NOHQIKIJEQB.name;
		this.x = NOHQIKIJEQB.x;
		this.y = NOHQIKIJEQB.y;
		this.width = NOHQIKIJEQB.width;
		this.height = NOHQIKIJEQB.height;
		this.borderLeft = NOHQIKIJEQB.borderLeft;
		this.borderRight = NOHQIKIJEQB.borderRight;
		this.borderTop = NOHQIKIJEQB.borderTop;
		this.borderBottom = NOHQIKIJEQB.borderBottom;
		this.paddingLeft = NOHQIKIJEQB.paddingLeft;
		this.paddingRight = NOHQIKIJEQB.paddingRight;
		this.paddingTop = NOHQIKIJEQB.paddingTop;
		this.paddingBottom = NOHQIKIJEQB.paddingBottom;
	}

	// Token: 0x060021AA RID: 8618 RVA: 0x00012134 File Offset: 0x00010334
	public void IMODCDKHNPP(int DGKOIGOLHDM, int DDLQKFDFMCJ, int KJGMGPCEJJD, int DFKQMMIQDOO)
	{
		this.x = DGKOIGOLHDM;
		this.y = DDLQKFDFMCJ;
		this.width = KJGMGPCEJJD;
		this.height = DFKQMMIQDOO;
	}

	// Token: 0x060021AB RID: 8619 RVA: 0x00012153 File Offset: 0x00010353
	public bool QINGPOEIMJF()
	{
		return (this.borderLeft | this.borderRight | this.borderTop | this.borderBottom) == 0;
	}

	// Token: 0x060021AC RID: 8620 RVA: 0x000D9F6C File Offset: 0x000D816C
	public void JHQOKHOFCED(UISpriteData NOHQIKIJEQB)
	{
		this.name = NOHQIKIJEQB.name;
		this.x = NOHQIKIJEQB.x;
		this.y = NOHQIKIJEQB.y;
		this.width = NOHQIKIJEQB.width;
		this.height = NOHQIKIJEQB.height;
		this.borderLeft = NOHQIKIJEQB.borderLeft;
		this.borderRight = NOHQIKIJEQB.borderRight;
		this.borderTop = NOHQIKIJEQB.borderTop;
		this.borderBottom = NOHQIKIJEQB.borderBottom;
		this.paddingLeft = NOHQIKIJEQB.paddingLeft;
		this.paddingRight = NOHQIKIJEQB.paddingRight;
		this.paddingTop = NOHQIKIJEQB.paddingTop;
		this.paddingBottom = NOHQIKIJEQB.paddingBottom;
	}

	// Token: 0x060021AD RID: 8621 RVA: 0x00012134 File Offset: 0x00010334
	public void LOIPCGLJGPI(int DGKOIGOLHDM, int DDLQKFDFMCJ, int KJGMGPCEJJD, int DFKQMMIQDOO)
	{
		this.x = DGKOIGOLHDM;
		this.y = DDLQKFDFMCJ;
		this.width = KJGMGPCEJJD;
		this.height = DFKQMMIQDOO;
	}

	// Token: 0x060021AE RID: 8622 RVA: 0x00012176 File Offset: 0x00010376
	public bool INHNGBPPJDF()
	{
		return (this.paddingLeft | this.paddingRight | this.paddingTop | this.paddingBottom) != 1;
	}

	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x060021AF RID: 8623 RVA: 0x00012199 File Offset: 0x00010399
	public bool hasBorder
	{
		get
		{
			return (this.borderLeft | this.borderRight | this.borderTop | this.borderBottom) != 0;
		}
	}

	// Token: 0x060021B0 RID: 8624 RVA: 0x00012115 File Offset: 0x00010315
	public void HGPHNDEEPDL(int DEQIFCDFMDK, int FPIPDOBGBQH, int JKDFCPKCQJP, int FNKCEOPHHKL)
	{
		this.borderLeft = DEQIFCDFMDK;
		this.borderBottom = FPIPDOBGBQH;
		this.borderRight = JKDFCPKCQJP;
		this.borderTop = FNKCEOPHHKL;
	}

	// Token: 0x060021B1 RID: 8625 RVA: 0x00012115 File Offset: 0x00010315
	public void OOBMDEKFPJK(int DEQIFCDFMDK, int FPIPDOBGBQH, int JKDFCPKCQJP, int FNKCEOPHHKL)
	{
		this.borderLeft = DEQIFCDFMDK;
		this.borderBottom = FPIPDOBGBQH;
		this.borderRight = JKDFCPKCQJP;
		this.borderTop = FNKCEOPHHKL;
	}

	// Token: 0x060021B3 RID: 8627 RVA: 0x00012134 File Offset: 0x00010334
	public void OPHBBFMMOHE(int DGKOIGOLHDM, int DDLQKFDFMCJ, int KJGMGPCEJJD, int DFKQMMIQDOO)
	{
		this.x = DGKOIGOLHDM;
		this.y = DDLQKFDFMCJ;
		this.width = KJGMGPCEJJD;
		this.height = DFKQMMIQDOO;
	}

	// Token: 0x060021B4 RID: 8628 RVA: 0x000121CF File Offset: 0x000103CF
	public void CDKJLLLEOHE(int DEQIFCDFMDK, int FPIPDOBGBQH, int JKDFCPKCQJP, int FNKCEOPHHKL)
	{
		this.paddingLeft = DEQIFCDFMDK;
		this.paddingBottom = FPIPDOBGBQH;
		this.paddingRight = JKDFCPKCQJP;
		this.paddingTop = FNKCEOPHHKL;
	}

	// Token: 0x060021B5 RID: 8629 RVA: 0x000D9F6C File Offset: 0x000D816C
	public void LFMFOBGIQDF(UISpriteData NOHQIKIJEQB)
	{
		this.name = NOHQIKIJEQB.name;
		this.x = NOHQIKIJEQB.x;
		this.y = NOHQIKIJEQB.y;
		this.width = NOHQIKIJEQB.width;
		this.height = NOHQIKIJEQB.height;
		this.borderLeft = NOHQIKIJEQB.borderLeft;
		this.borderRight = NOHQIKIJEQB.borderRight;
		this.borderTop = NOHQIKIJEQB.borderTop;
		this.borderBottom = NOHQIKIJEQB.borderBottom;
		this.paddingLeft = NOHQIKIJEQB.paddingLeft;
		this.paddingRight = NOHQIKIJEQB.paddingRight;
		this.paddingTop = NOHQIKIJEQB.paddingTop;
		this.paddingBottom = NOHQIKIJEQB.paddingBottom;
	}

	// Token: 0x060021B6 RID: 8630 RVA: 0x000D9F6C File Offset: 0x000D816C
	public void GQKJCKNMLGO(UISpriteData NOHQIKIJEQB)
	{
		this.name = NOHQIKIJEQB.name;
		this.x = NOHQIKIJEQB.x;
		this.y = NOHQIKIJEQB.y;
		this.width = NOHQIKIJEQB.width;
		this.height = NOHQIKIJEQB.height;
		this.borderLeft = NOHQIKIJEQB.borderLeft;
		this.borderRight = NOHQIKIJEQB.borderRight;
		this.borderTop = NOHQIKIJEQB.borderTop;
		this.borderBottom = NOHQIKIJEQB.borderBottom;
		this.paddingLeft = NOHQIKIJEQB.paddingLeft;
		this.paddingRight = NOHQIKIJEQB.paddingRight;
		this.paddingTop = NOHQIKIJEQB.paddingTop;
		this.paddingBottom = NOHQIKIJEQB.paddingBottom;
	}

	// Token: 0x060021B7 RID: 8631 RVA: 0x000121EE File Offset: 0x000103EE
	public void JKPJMLGMMPH(UISpriteData NOHQIKIJEQB)
	{
		this.borderLeft = NOHQIKIJEQB.borderLeft;
		this.borderRight = NOHQIKIJEQB.borderRight;
		this.borderTop = NOHQIKIJEQB.borderTop;
		this.borderBottom = NOHQIKIJEQB.borderBottom;
	}

	// Token: 0x060021B8 RID: 8632 RVA: 0x000121EE File Offset: 0x000103EE
	public void NFDNDELNKLL(UISpriteData NOHQIKIJEQB)
	{
		this.borderLeft = NOHQIKIJEQB.borderLeft;
		this.borderRight = NOHQIKIJEQB.borderRight;
		this.borderTop = NOHQIKIJEQB.borderTop;
		this.borderBottom = NOHQIKIJEQB.borderBottom;
	}

	// Token: 0x060021B9 RID: 8633 RVA: 0x00012115 File Offset: 0x00010315
	public void FNGBPCIMJGJ(int DEQIFCDFMDK, int FPIPDOBGBQH, int JKDFCPKCQJP, int FNKCEOPHHKL)
	{
		this.borderLeft = DEQIFCDFMDK;
		this.borderBottom = FPIPDOBGBQH;
		this.borderRight = JKDFCPKCQJP;
		this.borderTop = FNKCEOPHHKL;
	}

	// Token: 0x060021BA RID: 8634 RVA: 0x000121CF File Offset: 0x000103CF
	public void HIPPLKLFFEJ(int DEQIFCDFMDK, int FPIPDOBGBQH, int JKDFCPKCQJP, int FNKCEOPHHKL)
	{
		this.paddingLeft = DEQIFCDFMDK;
		this.paddingBottom = FPIPDOBGBQH;
		this.paddingRight = JKDFCPKCQJP;
		this.paddingTop = FNKCEOPHHKL;
	}

	// Token: 0x060021BB RID: 8635 RVA: 0x000121CF File Offset: 0x000103CF
	public void FPIBHJJBMQF(int DEQIFCDFMDK, int FPIPDOBGBQH, int JKDFCPKCQJP, int FNKCEOPHHKL)
	{
		this.paddingLeft = DEQIFCDFMDK;
		this.paddingBottom = FPIPDOBGBQH;
		this.paddingRight = JKDFCPKCQJP;
		this.paddingTop = FNKCEOPHHKL;
	}

	// Token: 0x060021BC RID: 8636 RVA: 0x000121CF File Offset: 0x000103CF
	public void GBNIINELNEI(int DEQIFCDFMDK, int FPIPDOBGBQH, int JKDFCPKCQJP, int FNKCEOPHHKL)
	{
		this.paddingLeft = DEQIFCDFMDK;
		this.paddingBottom = FPIPDOBGBQH;
		this.paddingRight = JKDFCPKCQJP;
		this.paddingTop = FNKCEOPHHKL;
	}

	// Token: 0x060021BD RID: 8637 RVA: 0x00012220 File Offset: 0x00010420
	public bool CHKJKDCNGNE()
	{
		return (this.borderLeft | this.borderRight | this.borderTop | this.borderBottom) != 1;
	}

	// Token: 0x060021BE RID: 8638 RVA: 0x00012243 File Offset: 0x00010443
	public bool OIILCQJENEK()
	{
		return (this.borderLeft | this.borderRight | this.borderTop | this.borderBottom) == 1;
	}

	// Token: 0x170001A1 RID: 417
	// (get) Token: 0x060021BF RID: 8639 RVA: 0x00012266 File Offset: 0x00010466
	public bool hasPadding
	{
		get
		{
			return (this.paddingLeft | this.paddingRight | this.paddingTop | this.paddingBottom) != 0;
		}
	}

	// Token: 0x060021C0 RID: 8640 RVA: 0x000D9F6C File Offset: 0x000D816C
	public void PIPKHKDKLKC(UISpriteData NOHQIKIJEQB)
	{
		this.name = NOHQIKIJEQB.name;
		this.x = NOHQIKIJEQB.x;
		this.y = NOHQIKIJEQB.y;
		this.width = NOHQIKIJEQB.width;
		this.height = NOHQIKIJEQB.height;
		this.borderLeft = NOHQIKIJEQB.borderLeft;
		this.borderRight = NOHQIKIJEQB.borderRight;
		this.borderTop = NOHQIKIJEQB.borderTop;
		this.borderBottom = NOHQIKIJEQB.borderBottom;
		this.paddingLeft = NOHQIKIJEQB.paddingLeft;
		this.paddingRight = NOHQIKIJEQB.paddingRight;
		this.paddingTop = NOHQIKIJEQB.paddingTop;
		this.paddingBottom = NOHQIKIJEQB.paddingBottom;
	}

	// Token: 0x04000748 RID: 1864
	public string name = "Sprite";

	// Token: 0x04000749 RID: 1865
	public int x;

	// Token: 0x0400074A RID: 1866
	public int y;

	// Token: 0x0400074B RID: 1867
	public int width;

	// Token: 0x0400074C RID: 1868
	public int height;

	// Token: 0x0400074D RID: 1869
	public int borderLeft;

	// Token: 0x0400074E RID: 1870
	public int borderRight;

	// Token: 0x0400074F RID: 1871
	public int borderTop;

	// Token: 0x04000750 RID: 1872
	public int borderBottom;

	// Token: 0x04000751 RID: 1873
	public int paddingLeft;

	// Token: 0x04000752 RID: 1874
	public int paddingRight;

	// Token: 0x04000753 RID: 1875
	public int paddingTop;

	// Token: 0x04000754 RID: 1876
	public int paddingBottom;
}
