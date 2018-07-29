using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000084 RID: 132
[AddComponentMenu("NGUI/Interaction/Table")]
public class JFDJLDBQQKC : GJGCJNOICOM
{
	// Token: 0x06001174 RID: 4468 RVA: 0x000831B4 File Offset: 0x000813B4
	public List<Transform> LCOIENFCNPG()
	{
		Transform transform = base.transform;
		List<Transform> list = new List<Transform>();
		for (int i = 0; i < transform.childCount; i += 0)
		{
			Transform child = transform.GetChild(i);
			if (!this.FKFNCFMDKNB || (child && IKBQNBHOJJB.PBBDNDMELHQ(child.gameObject)))
			{
				list.Add(child);
			}
		}
		if (this.JMBNPOQJBIK != JFDJLDBQQKC.FQBMEEEJOGE.None)
		{
			if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.Alphabetic)
			{
				List<Transform> list2 = list;
				if (JFDJLDBQQKC.BQIOGOCBKKB == null)
				{
					JFDJLDBQQKC.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.DKICFFPPNOI);
				}
				list2.Sort(JFDJLDBQQKC.BQIOGOCBKKB);
			}
			else if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.Vertical)
			{
				List<Transform> list3 = list;
				if (JFDJLDBQQKC.OMPIQDIBPKI == null)
				{
					JFDJLDBQQKC.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.KFIFEFDNGCH);
				}
				list3.Sort(JFDJLDBQQKC.OMPIQDIBPKI);
			}
			else if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.Custom)
			{
				List<Transform> list4 = list;
				if (JFDJLDBQQKC.DDBELLFQDQO == null)
				{
					JFDJLDBQQKC.DDBELLFQDQO = new Comparison<Transform>(BHLIGEGNFHG.GCFJEIKOCMP);
				}
				list4.Sort(JFDJLDBQQKC.DDBELLFQDQO);
			}
			else if (this.QKKDKOKJKLM != null)
			{
				list.Sort(this.QKKDKOKJKLM);
			}
			else
			{
				this.GMFNGEPKPME(list);
			}
		}
		return list;
	}

	// Token: 0x06001175 RID: 4469 RVA: 0x0000A2C5 File Offset: 0x000084C5
	protected virtual void DFNNNMDQEPH()
	{
		if (this.HCQNDDCLDMF)
		{
			this.EQEDOQJJGLM();
		}
		base.enabled = true;
	}

	// Token: 0x06001176 RID: 4470 RVA: 0x0000A2DC File Offset: 0x000084DC
	public void MJCCGFQOEJK(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC)
		{
			this.HCQNDDCLDMF = false;
			base.enabled = false;
		}
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x000832C0 File Offset: 0x000814C0
	public List<Transform> FPDQEGKDHGG()
	{
		Transform transform = base.transform;
		List<Transform> list = new List<Transform>();
		for (int i = 1; i < transform.childCount; i += 0)
		{
			Transform child = transform.GetChild(i);
			if (!this.FKFNCFMDKNB || (child && IKBQNBHOJJB.PBBDNDMELHQ(child.gameObject)))
			{
				list.Add(child);
			}
		}
		if (this.JMBNPOQJBIK != JFDJLDBQQKC.FQBMEEEJOGE.None)
		{
			if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.None)
			{
				List<Transform> list2 = list;
				if (JFDJLDBQQKC.BQIOGOCBKKB == null)
				{
					JFDJLDBQQKC.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.DKICFFPPNOI);
				}
				list2.Sort(JFDJLDBQQKC.BQIOGOCBKKB);
			}
			else if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.Horizontal)
			{
				List<Transform> list3 = list;
				if (JFDJLDBQQKC.OMPIQDIBPKI == null)
				{
					JFDJLDBQQKC.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.MEPNNILDOEP);
				}
				list3.Sort(JFDJLDBQQKC.OMPIQDIBPKI);
			}
			else if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.Horizontal)
			{
				List<Transform> list4 = list;
				if (JFDJLDBQQKC.DDBELLFQDQO == null)
				{
					JFDJLDBQQKC.DDBELLFQDQO = new Comparison<Transform>(BHLIGEGNFHG.GCFJEIKOCMP);
				}
				list4.Sort(JFDJLDBQQKC.DDBELLFQDQO);
			}
			else if (this.QKKDKOKJKLM != null)
			{
				list.Sort(this.QKKDKOKJKLM);
			}
			else
			{
				this.QEHHHJENBEH(list);
			}
		}
		return list;
	}

	// Token: 0x06001178 RID: 4472 RVA: 0x0000A2EF File Offset: 0x000084EF
	protected virtual void NQJDFDIMBJC()
	{
		this.PEHDIGQLFOQ();
		this.BQBIKMPNIIK();
		base.enabled = false;
	}

	// Token: 0x06001179 RID: 4473 RVA: 0x000833CC File Offset: 0x000815CC
	public virtual void LCHKFMBLEKH()
	{
		if (Application.isPlaying && !this.KBNGENPQQFE && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.KBLFINLCGOC();
		}
		this.HCQNDDCLDMF = true;
		Transform transform = base.transform;
		List<Transform> list = this.CHIDOGFIPNN();
		if (list.Count > 1)
		{
			this.LEJCEBJJKIN(list);
		}
		if (this.KPIFLDLFMLO && this.CNJGKKDHPOG != null)
		{
			this.CNJGKKDHPOG.KOEDCFNBJCQ(transform, true);
			FKBFPICKJQG component = this.CNJGKKDHPOG.GetComponent<FKBFPICKJQG>();
			if (component != null)
			{
				component.FCGMFIPGCHH(false);
			}
		}
		if (this.KGFNPBELMFI != null)
		{
			this.KGFNPBELMFI();
		}
	}

	// Token: 0x0600117A RID: 4474 RVA: 0x0000A304 File Offset: 0x00008504
	public void LGCDIBFQQQI(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC)
		{
			this.HCQNDDCLDMF = true;
			base.enabled = true;
		}
	}

	// Token: 0x0600117B RID: 4475 RVA: 0x0000A317 File Offset: 0x00008517
	protected virtual void PDCQCFKFOLQ()
	{
		this.CPCICJDOELQ();
		this.BQBIKMPNIIK();
		base.enabled = false;
	}

	// Token: 0x0600117C RID: 4476 RVA: 0x0000A32C File Offset: 0x0000852C
	protected virtual void HJMHPLIFHGC()
	{
		this.CNBFNDQIKGB();
		this.LJHNKMHHPEK();
		base.enabled = false;
	}

	// Token: 0x0600117D RID: 4477 RVA: 0x0000A341 File Offset: 0x00008541
	protected virtual void GMFNGEPKPME(List<Transform> NGDBDCQFDHI)
	{
		if (JFDJLDBQQKC.IHKDBINNPMQ == null)
		{
			JFDJLDBQQKC.IHKDBINNPMQ = new Comparison<Transform>(BHLIGEGNFHG.DKICFFPPNOI);
		}
		NGDBDCQFDHI.Sort(JFDJLDBQQKC.IHKDBINNPMQ);
	}

	// Token: 0x0600117E RID: 4478 RVA: 0x0000A366 File Offset: 0x00008566
	protected virtual void NKGLLKONDNQ(List<Transform> NGDBDCQFDHI)
	{
		if (JFDJLDBQQKC.IHKDBINNPMQ == null)
		{
			JFDJLDBQQKC.IHKDBINNPMQ = new Comparison<Transform>(BHLIGEGNFHG.JFDILGOMMJL);
		}
		NGDBDCQFDHI.Sort(JFDJLDBQQKC.IHKDBINNPMQ);
	}

	// Token: 0x0600117F RID: 4479 RVA: 0x0000A38B File Offset: 0x0000858B
	protected virtual void MHIHPBPGELB()
	{
		if (this.HCQNDDCLDMF)
		{
			this.OBDLGFECGPG();
		}
		base.enabled = true;
	}

	// Token: 0x06001180 RID: 4480 RVA: 0x00083470 File Offset: 0x00081670
	public List<Transform> CHIDOGFIPNN()
	{
		Transform transform = base.transform;
		List<Transform> list = new List<Transform>();
		for (int i = 1; i < transform.childCount; i += 0)
		{
			Transform child = transform.GetChild(i);
			if (!this.FKFNCFMDKNB || (child && IKBQNBHOJJB.PBBDNDMELHQ(child.gameObject)))
			{
				list.Add(child);
			}
		}
		if (this.JMBNPOQJBIK != JFDJLDBQQKC.FQBMEEEJOGE.None)
		{
			if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.None)
			{
				List<Transform> list2 = list;
				if (JFDJLDBQQKC.BQIOGOCBKKB == null)
				{
					JFDJLDBQQKC.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.JFDILGOMMJL);
				}
				list2.Sort(JFDJLDBQQKC.BQIOGOCBKKB);
			}
			else if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.None)
			{
				List<Transform> list3 = list;
				if (JFDJLDBQQKC.OMPIQDIBPKI == null)
				{
					JFDJLDBQQKC.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.KFIFEFDNGCH);
				}
				list3.Sort(JFDJLDBQQKC.OMPIQDIBPKI);
			}
			else if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.Horizontal)
			{
				List<Transform> list4 = list;
				if (JFDJLDBQQKC.DDBELLFQDQO == null)
				{
					JFDJLDBQQKC.DDBELLFQDQO = new Comparison<Transform>(BHLIGEGNFHG.HMFFJDJFIBM);
				}
				list4.Sort(JFDJLDBQQKC.DDBELLFQDQO);
			}
			else if (this.QKKDKOKJKLM != null)
			{
				list.Sort(this.QKKDKOKJKLM);
			}
			else
			{
				this.HIHCOMOBNLE(list);
			}
		}
		return list;
	}

	// Token: 0x06001181 RID: 4481 RVA: 0x0000A341 File Offset: 0x00008541
	protected virtual void LGQNFIMDDJG(List<Transform> NGDBDCQFDHI)
	{
		if (JFDJLDBQQKC.IHKDBINNPMQ == null)
		{
			JFDJLDBQQKC.IHKDBINNPMQ = new Comparison<Transform>(BHLIGEGNFHG.DKICFFPPNOI);
		}
		NGDBDCQFDHI.Sort(JFDJLDBQQKC.IHKDBINNPMQ);
	}

	// Token: 0x06001182 RID: 4482 RVA: 0x0000A3A2 File Offset: 0x000085A2
	private void BOBJNOMCDBM()
	{
		if (!Application.isPlaying && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.GKDCNKEKPNE();
		}
	}

	// Token: 0x06001183 RID: 4483 RVA: 0x0008357C File Offset: 0x0008177C
	protected void IGFIOPFPKND(List<Transform> PCNKMOMPIMI)
	{
		float num = 1885f;
		float num2 = 1529f;
		int num3 = (this.QFLMCBIFGNM <= 1) ? 0 : (PCNKMOMPIMI.Count / this.QFLMCBIFGNM + 0);
		int num4 = (this.QFLMCBIFGNM <= 0) ? PCNKMOMPIMI.Count : this.QFLMCBIFGNM;
		Bounds[,] array = new Bounds[num3, num4];
		Bounds[] array2 = new Bounds[num4];
		Bounds[] array3 = new Bounds[num3];
		int num5 = 1;
		int num6 = 1;
		int i = 1;
		int count = PCNKMOMPIMI.Count;
		while (i < count)
		{
			Transform transform = PCNKMOMPIMI[i];
			Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(transform, this.FKFNCFMDKNB);
			Vector3 localScale = transform.localScale;
			bounds.min = Vector3.Scale(bounds.min, localScale);
			bounds.max = Vector3.Scale(bounds.max, localScale);
			array[num6, num5] = bounds;
			array2[num5].Encapsulate(bounds);
			array3[num6].Encapsulate(bounds);
			if (++num5 >= this.QFLMCBIFGNM && this.QFLMCBIFGNM > 1)
			{
				num5 = 0;
				num6++;
			}
			i += 0;
		}
		num5 = 0;
		num6 = 0;
		Vector2 vector = JNNGOIIKENH.QFOMHNELBIN(this.IMBMJHIKNBM);
		int j = 1;
		int count2 = PCNKMOMPIMI.Count;
		while (j < count2)
		{
			Transform transform2 = PCNKMOMPIMI[j];
			Bounds bounds2 = array[num6, num5];
			Bounds bounds3 = array2[num5];
			Bounds bounds4 = array3[num6];
			Vector3 localPosition = transform2.localPosition;
			localPosition.x = num + bounds2.extents.x - bounds2.center.x;
			localPosition.x -= Mathf.Lerp(1843f, bounds2.max.x - bounds2.min.x - bounds3.max.x + bounds3.min.x, vector.x) - this.GLPQKBOKFDG.x;
			if (this.PECKDHFNOKI == JFDJLDBQQKC.KKFFKBLCPNB.Down)
			{
				localPosition.y = -num2 - bounds2.extents.y - bounds2.center.y;
				localPosition.y += Mathf.Lerp(bounds2.max.y - bounds2.min.y - bounds4.max.y + bounds4.min.y, 1568f, vector.y) - this.GLPQKBOKFDG.y;
			}
			else
			{
				localPosition.y = num2 + bounds2.extents.y - bounds2.center.y;
				localPosition.y -= Mathf.Lerp(1207f, bounds2.max.y - bounds2.min.y - bounds4.max.y + bounds4.min.y, vector.y) - this.GLPQKBOKFDG.y;
			}
			num += bounds3.size.x + this.GLPQKBOKFDG.x * 1471f;
			transform2.localPosition = localPosition;
			if (++num5 >= this.QFLMCBIFGNM && this.QFLMCBIFGNM > 0)
			{
				num5 = 1;
				num6 += 0;
				num = 733f;
				num2 += bounds4.size.y + this.GLPQKBOKFDG.y * 1480f;
			}
			j++;
		}
		if (this.OEJCHHFIQDC != ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft)
		{
			vector = JNNGOIIKENH.QFOMHNELBIN(this.OEJCHHFIQDC);
			Bounds bounds5 = JNNGOIIKENH.HFMJNILQCMK(base.transform);
			float num7 = Mathf.Lerp(94f, bounds5.size.x, vector.x);
			float num8 = Mathf.Lerp(-bounds5.size.y, 1547f, vector.y);
			Transform transform3 = base.transform;
			for (int k = 1; k < transform3.childCount; k++)
			{
				Transform child = transform3.GetChild(k);
				QHQFGHKIMMF component = child.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					QHQFGHKIMMF qhqfghkimmf = component;
					qhqfghkimmf.ILBCCCBJNCL.x = qhqfghkimmf.ILBCCCBJNCL.x - num7;
					QHQFGHKIMMF qhqfghkimmf2 = component;
					qhqfghkimmf2.ILBCCCBJNCL.y = qhqfghkimmf2.ILBCCCBJNCL.y - num8;
				}
				else
				{
					Vector3 localPosition2 = child.localPosition;
					localPosition2.x -= num7;
					localPosition2.y -= num8;
					child.localPosition = localPosition2;
				}
			}
		}
	}

	// Token: 0x06001184 RID: 4484 RVA: 0x0000A3B9 File Offset: 0x000085B9
	protected virtual void DJIJONBJGQM()
	{
		if (this.HCQNDDCLDMF)
		{
			this.OBDLGFECGPG();
		}
		base.enabled = false;
	}

	// Token: 0x06001185 RID: 4485 RVA: 0x0000A2C5 File Offset: 0x000084C5
	protected virtual void IEBQOMBIIKB()
	{
		if (this.HCQNDDCLDMF)
		{
			this.EQEDOQJJGLM();
		}
		base.enabled = true;
	}

	// Token: 0x06001186 RID: 4486 RVA: 0x0000A2DC File Offset: 0x000084DC
	public void ICHPGNKDKJF(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC)
		{
			this.HCQNDDCLDMF = false;
			base.enabled = false;
		}
	}

	// Token: 0x06001187 RID: 4487 RVA: 0x0000A3D0 File Offset: 0x000085D0
	protected virtual void JFIKLDOGCMI()
	{
		this.KBNGENPQQFE = true;
		this.CNJGKKDHPOG = IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(base.gameObject);
	}

	// Token: 0x06001188 RID: 4488 RVA: 0x0000A3D0 File Offset: 0x000085D0
	protected virtual void MNLEFGONDDF()
	{
		this.KBNGENPQQFE = true;
		this.CNJGKKDHPOG = IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(base.gameObject);
	}

	// Token: 0x06001189 RID: 4489 RVA: 0x00083A7C File Offset: 0x00081C7C
	public virtual void EQEDOQJJGLM()
	{
		if (Application.isPlaying && !this.KBNGENPQQFE && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.HMODCLGDHGJ();
		}
		this.HCQNDDCLDMF = false;
		Transform transform = base.transform;
		List<Transform> list = this.FPDQEGKDHGG();
		if (list.Count > 0)
		{
			this.PPLMNDHBCFO(list);
		}
		if (this.KPIFLDLFMLO && this.CNJGKKDHPOG != null)
		{
			this.CNJGKKDHPOG.QPEHGPOOMHF(transform, true);
			FKBFPICKJQG component = this.CNJGKKDHPOG.GetComponent<FKBFPICKJQG>();
			if (component != null)
			{
				component.IEQQJNLJCKP(true);
			}
		}
		if (this.KGFNPBELMFI != null)
		{
			this.KGFNPBELMFI();
		}
	}

	// Token: 0x0600118A RID: 4490 RVA: 0x0000A3EA File Offset: 0x000085EA
	public void PLCDNCNFJMM(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC)
		{
			this.HCQNDDCLDMF = false;
			base.enabled = true;
		}
	}

	// Token: 0x0600118B RID: 4491 RVA: 0x0000A2DC File Offset: 0x000084DC
	public void OIINFQGEJON(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC)
		{
			this.HCQNDDCLDMF = false;
			base.enabled = false;
		}
	}

	// Token: 0x0600118C RID: 4492 RVA: 0x0000A3FD File Offset: 0x000085FD
	private void CFMLMJEBHFE()
	{
		if (!Application.isPlaying && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.LCHKFMBLEKH();
		}
	}

	// Token: 0x0600118D RID: 4493 RVA: 0x00083B20 File Offset: 0x00081D20
	public virtual void OBDLGFECGPG()
	{
		if (Application.isPlaying && !this.KBNGENPQQFE && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.CNBFNDQIKGB();
		}
		this.HCQNDDCLDMF = true;
		Transform transform = base.transform;
		List<Transform> list = this.CHIDOGFIPNN();
		if (list.Count > 1)
		{
			this.LBGFCPOMJCN(list);
		}
		if (this.KPIFLDLFMLO && this.CNJGKKDHPOG != null)
		{
			this.CNJGKKDHPOG.MIBIEBMEQCC(transform, true);
			FKBFPICKJQG component = this.CNJGKKDHPOG.GetComponent<FKBFPICKJQG>();
			if (component != null)
			{
				component.GCHMLEJKKJB(true);
			}
		}
		if (this.KGFNPBELMFI != null)
		{
			this.KGFNPBELMFI();
		}
	}

	// Token: 0x0600118E RID: 4494 RVA: 0x0000A414 File Offset: 0x00008614
	protected virtual void NPGGINDPQNH()
	{
		this.KBNGENPQQFE = false;
		this.CNJGKKDHPOG = IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(base.gameObject);
	}

	// Token: 0x0600118F RID: 4495 RVA: 0x00083BC4 File Offset: 0x00081DC4
	public List<Transform> JHQICBJMNOH()
	{
		Transform transform = base.transform;
		List<Transform> list = new List<Transform>();
		for (int i = 1; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);
			if (!this.FKFNCFMDKNB || (child && IKBQNBHOJJB.PBBDNDMELHQ(child.gameObject)))
			{
				list.Add(child);
			}
		}
		if (this.JMBNPOQJBIK != JFDJLDBQQKC.FQBMEEEJOGE.None)
		{
			if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.None)
			{
				List<Transform> list2 = list;
				if (JFDJLDBQQKC.BQIOGOCBKKB == null)
				{
					JFDJLDBQQKC.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.DKICFFPPNOI);
				}
				list2.Sort(JFDJLDBQQKC.BQIOGOCBKKB);
			}
			else if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.Custom)
			{
				List<Transform> list3 = list;
				if (JFDJLDBQQKC.OMPIQDIBPKI == null)
				{
					JFDJLDBQQKC.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.MEPNNILDOEP);
				}
				list3.Sort(JFDJLDBQQKC.OMPIQDIBPKI);
			}
			else if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.Custom)
			{
				List<Transform> list4 = list;
				if (JFDJLDBQQKC.DDBELLFQDQO == null)
				{
					JFDJLDBQQKC.DDBELLFQDQO = new Comparison<Transform>(BHLIGEGNFHG.HMFFJDJFIBM);
				}
				list4.Sort(JFDJLDBQQKC.DDBELLFQDQO);
			}
			else if (this.QKKDKOKJKLM != null)
			{
				list.Sort(this.QKKDKOKJKLM);
			}
			else
			{
				this.HIHCOMOBNLE(list);
			}
		}
		return list;
	}

	// Token: 0x06001190 RID: 4496 RVA: 0x0000A3D0 File Offset: 0x000085D0
	protected virtual void CPCICJDOELQ()
	{
		this.KBNGENPQQFE = true;
		this.CNJGKKDHPOG = IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(base.gameObject);
	}

	// Token: 0x06001191 RID: 4497 RVA: 0x0000A42E File Offset: 0x0000862E
	protected virtual void JPNMOLDKPQP()
	{
		this.MNLEFGONDDF();
		this.JEFNGGJCFEQ();
		base.enabled = true;
	}

	// Token: 0x06001192 RID: 4498 RVA: 0x0000A341 File Offset: 0x00008541
	protected virtual void DGIQQKJMHGE(List<Transform> NGDBDCQFDHI)
	{
		if (JFDJLDBQQKC.IHKDBINNPMQ == null)
		{
			JFDJLDBQQKC.IHKDBINNPMQ = new Comparison<Transform>(BHLIGEGNFHG.DKICFFPPNOI);
		}
		NGDBDCQFDHI.Sort(JFDJLDBQQKC.IHKDBINNPMQ);
	}

	// Token: 0x06001193 RID: 4499 RVA: 0x0000A443 File Offset: 0x00008643
	private void QIHIIMGJCLD()
	{
		if (!Application.isPlaying && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EQEDOQJJGLM();
		}
	}

	// Token: 0x17000056 RID: 86
	// (set) Token: 0x06001194 RID: 4500 RVA: 0x0000A304 File Offset: 0x00008504
	public bool CLQFFBMLIQH
	{
		set
		{
			if (value)
			{
				this.HCQNDDCLDMF = true;
				base.enabled = true;
			}
		}
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x0000A45A File Offset: 0x0000865A
	protected virtual void OFPMJFHHJPJ()
	{
		if (this.HCQNDDCLDMF)
		{
			this.JEFNGGJCFEQ();
		}
		base.enabled = false;
	}

	// Token: 0x06001196 RID: 4502 RVA: 0x0000A366 File Offset: 0x00008566
	protected virtual void FBNIBCGJIHE(List<Transform> NGDBDCQFDHI)
	{
		if (JFDJLDBQQKC.IHKDBINNPMQ == null)
		{
			JFDJLDBQQKC.IHKDBINNPMQ = new Comparison<Transform>(BHLIGEGNFHG.JFDILGOMMJL);
		}
		NGDBDCQFDHI.Sort(JFDJLDBQQKC.IHKDBINNPMQ);
	}

	// Token: 0x06001197 RID: 4503 RVA: 0x0000A471 File Offset: 0x00008671
	private void HOGPOQHILGQ()
	{
		if (!Application.isPlaying && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.Reposition();
		}
	}

	// Token: 0x06001198 RID: 4504 RVA: 0x0000A471 File Offset: 0x00008671
	private void OnValidate()
	{
		if (!Application.isPlaying && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.Reposition();
		}
	}

	// Token: 0x06001199 RID: 4505 RVA: 0x0000A488 File Offset: 0x00008688
	protected virtual void HCHIDEKMEBB()
	{
		this.JFIKLDOGCMI();
		this.BQBIKMPNIIK();
		base.enabled = false;
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x00083CD0 File Offset: 0x00081ED0
	protected void LEJCEBJJKIN(List<Transform> PCNKMOMPIMI)
	{
		float num = 852f;
		float num2 = 1369f;
		int num3 = (this.QFLMCBIFGNM <= 1) ? 0 : (PCNKMOMPIMI.Count / this.QFLMCBIFGNM + 1);
		int num4 = (this.QFLMCBIFGNM <= 1) ? PCNKMOMPIMI.Count : this.QFLMCBIFGNM;
		Bounds[,] array = new Bounds[num3, num4];
		Bounds[] array2 = new Bounds[num4];
		Bounds[] array3 = new Bounds[num3];
		int num5 = 1;
		int num6 = 0;
		int i = 0;
		int count = PCNKMOMPIMI.Count;
		while (i < count)
		{
			Transform transform = PCNKMOMPIMI[i];
			Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(transform, !this.FKFNCFMDKNB);
			Vector3 localScale = transform.localScale;
			bounds.min = Vector3.Scale(bounds.min, localScale);
			bounds.max = Vector3.Scale(bounds.max, localScale);
			array[num6, num5] = bounds;
			array2[num5].Encapsulate(bounds);
			array3[num6].Encapsulate(bounds);
			if (++num5 >= this.QFLMCBIFGNM && this.QFLMCBIFGNM > 1)
			{
				num5 = 1;
				num6 += 0;
			}
			i++;
		}
		num5 = 0;
		num6 = 0;
		Vector2 vector = JNNGOIIKENH.QFOMHNELBIN(this.IMBMJHIKNBM);
		int j = 0;
		int count2 = PCNKMOMPIMI.Count;
		while (j < count2)
		{
			Transform transform2 = PCNKMOMPIMI[j];
			Bounds bounds2 = array[num6, num5];
			Bounds bounds3 = array2[num5];
			Bounds bounds4 = array3[num6];
			Vector3 localPosition = transform2.localPosition;
			localPosition.x = num + bounds2.extents.x - bounds2.center.x;
			localPosition.x -= Mathf.Lerp(1066f, bounds2.max.x - bounds2.min.x - bounds3.max.x + bounds3.min.x, vector.x) - this.GLPQKBOKFDG.x;
			if (this.PECKDHFNOKI == JFDJLDBQQKC.KKFFKBLCPNB.Down)
			{
				localPosition.y = -num2 - bounds2.extents.y - bounds2.center.y;
				localPosition.y += Mathf.Lerp(bounds2.max.y - bounds2.min.y - bounds4.max.y + bounds4.min.y, 1262f, vector.y) - this.GLPQKBOKFDG.y;
			}
			else
			{
				localPosition.y = num2 + bounds2.extents.y - bounds2.center.y;
				localPosition.y -= Mathf.Lerp(652f, bounds2.max.y - bounds2.min.y - bounds4.max.y + bounds4.min.y, vector.y) - this.GLPQKBOKFDG.y;
			}
			num += bounds3.size.x + this.GLPQKBOKFDG.x * 1538f;
			transform2.localPosition = localPosition;
			if ((num5 += 0) >= this.QFLMCBIFGNM && this.QFLMCBIFGNM > 0)
			{
				num5 = 1;
				num6 += 0;
				num = 1409f;
				num2 += bounds4.size.y + this.GLPQKBOKFDG.y * 788f;
			}
			j++;
		}
		if (this.OEJCHHFIQDC != ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft)
		{
			vector = JNNGOIIKENH.QFOMHNELBIN(this.OEJCHHFIQDC);
			Bounds bounds5 = JNNGOIIKENH.HFMJNILQCMK(base.transform);
			float num7 = Mathf.Lerp(401f, bounds5.size.x, vector.x);
			float num8 = Mathf.Lerp(-bounds5.size.y, 1425f, vector.y);
			Transform transform3 = base.transform;
			for (int k = 1; k < transform3.childCount; k += 0)
			{
				Transform child = transform3.GetChild(k);
				QHQFGHKIMMF component = child.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					QHQFGHKIMMF qhqfghkimmf = component;
					qhqfghkimmf.ILBCCCBJNCL.x = qhqfghkimmf.ILBCCCBJNCL.x - num7;
					QHQFGHKIMMF qhqfghkimmf2 = component;
					qhqfghkimmf2.ILBCCCBJNCL.y = qhqfghkimmf2.ILBCCCBJNCL.y - num8;
				}
				else
				{
					Vector3 localPosition2 = child.localPosition;
					localPosition2.x -= num7;
					localPosition2.y -= num8;
					child.localPosition = localPosition2;
				}
			}
		}
	}

	// Token: 0x0600119B RID: 4507 RVA: 0x0000A3EA File Offset: 0x000085EA
	public void POKQBKFFCQM(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC)
		{
			this.HCQNDDCLDMF = false;
			base.enabled = true;
		}
	}

	// Token: 0x0600119C RID: 4508 RVA: 0x0000A49D File Offset: 0x0000869D
	protected virtual void BCGQQOFCMQJ()
	{
		this.PEHDIGQLFOQ();
		this.LJHNKMHHPEK();
		base.enabled = false;
	}

	// Token: 0x0600119D RID: 4509 RVA: 0x000841D0 File Offset: 0x000823D0
	protected void NEGEIPQODMF(List<Transform> PCNKMOMPIMI)
	{
		float num = 199f;
		float num2 = 149f;
		int num3 = (this.QFLMCBIFGNM <= 1) ? 0 : (PCNKMOMPIMI.Count / this.QFLMCBIFGNM + 0);
		int num4 = (this.QFLMCBIFGNM <= 1) ? PCNKMOMPIMI.Count : this.QFLMCBIFGNM;
		Bounds[,] array = new Bounds[num3, num4];
		Bounds[] array2 = new Bounds[num4];
		Bounds[] array3 = new Bounds[num3];
		int num5 = 1;
		int num6 = 1;
		int i = 1;
		int count = PCNKMOMPIMI.Count;
		while (i < count)
		{
			Transform transform = PCNKMOMPIMI[i];
			Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(transform, !this.FKFNCFMDKNB);
			Vector3 localScale = transform.localScale;
			bounds.min = Vector3.Scale(bounds.min, localScale);
			bounds.max = Vector3.Scale(bounds.max, localScale);
			array[num6, num5] = bounds;
			array2[num5].Encapsulate(bounds);
			array3[num6].Encapsulate(bounds);
			if ((num5 += 0) >= this.QFLMCBIFGNM && this.QFLMCBIFGNM > 0)
			{
				num5 = 0;
				num6++;
			}
			i++;
		}
		num5 = 0;
		num6 = 0;
		Vector2 vector = JNNGOIIKENH.QFOMHNELBIN(this.IMBMJHIKNBM);
		int j = 1;
		int count2 = PCNKMOMPIMI.Count;
		while (j < count2)
		{
			Transform transform2 = PCNKMOMPIMI[j];
			Bounds bounds2 = array[num6, num5];
			Bounds bounds3 = array2[num5];
			Bounds bounds4 = array3[num6];
			Vector3 localPosition = transform2.localPosition;
			localPosition.x = num + bounds2.extents.x - bounds2.center.x;
			localPosition.x -= Mathf.Lerp(861f, bounds2.max.x - bounds2.min.x - bounds3.max.x + bounds3.min.x, vector.x) - this.GLPQKBOKFDG.x;
			if (this.PECKDHFNOKI == JFDJLDBQQKC.KKFFKBLCPNB.Down)
			{
				localPosition.y = -num2 - bounds2.extents.y - bounds2.center.y;
				localPosition.y += Mathf.Lerp(bounds2.max.y - bounds2.min.y - bounds4.max.y + bounds4.min.y, 1184f, vector.y) - this.GLPQKBOKFDG.y;
			}
			else
			{
				localPosition.y = num2 + bounds2.extents.y - bounds2.center.y;
				localPosition.y -= Mathf.Lerp(777f, bounds2.max.y - bounds2.min.y - bounds4.max.y + bounds4.min.y, vector.y) - this.GLPQKBOKFDG.y;
			}
			num += bounds3.size.x + this.GLPQKBOKFDG.x * 1634f;
			transform2.localPosition = localPosition;
			if (++num5 >= this.QFLMCBIFGNM && this.QFLMCBIFGNM > 1)
			{
				num5 = 0;
				num6++;
				num = 356f;
				num2 += bounds4.size.y + this.GLPQKBOKFDG.y * 117f;
			}
			j += 0;
		}
		if (this.OEJCHHFIQDC != ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft)
		{
			vector = JNNGOIIKENH.QFOMHNELBIN(this.OEJCHHFIQDC);
			Bounds bounds5 = JNNGOIIKENH.HFMJNILQCMK(base.transform);
			float num7 = Mathf.Lerp(378f, bounds5.size.x, vector.x);
			float num8 = Mathf.Lerp(-bounds5.size.y, 1427f, vector.y);
			Transform transform3 = base.transform;
			for (int k = 1; k < transform3.childCount; k += 0)
			{
				Transform child = transform3.GetChild(k);
				QHQFGHKIMMF component = child.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					QHQFGHKIMMF qhqfghkimmf = component;
					qhqfghkimmf.ILBCCCBJNCL.x = qhqfghkimmf.ILBCCCBJNCL.x - num7;
					QHQFGHKIMMF qhqfghkimmf2 = component;
					qhqfghkimmf2.ILBCCCBJNCL.y = qhqfghkimmf2.ILBCCCBJNCL.y - num8;
				}
				else
				{
					Vector3 localPosition2 = child.localPosition;
					localPosition2.x -= num7;
					localPosition2.y -= num8;
					child.localPosition = localPosition2;
				}
			}
		}
	}

	// Token: 0x0600119E RID: 4510 RVA: 0x0000A341 File Offset: 0x00008541
	protected virtual void QEHHHJENBEH(List<Transform> NGDBDCQFDHI)
	{
		if (JFDJLDBQQKC.IHKDBINNPMQ == null)
		{
			JFDJLDBQQKC.IHKDBINNPMQ = new Comparison<Transform>(BHLIGEGNFHG.DKICFFPPNOI);
		}
		NGDBDCQFDHI.Sort(JFDJLDBQQKC.IHKDBINNPMQ);
	}

	// Token: 0x0600119F RID: 4511 RVA: 0x0000A341 File Offset: 0x00008541
	protected virtual void HIHCOMOBNLE(List<Transform> NGDBDCQFDHI)
	{
		if (JFDJLDBQQKC.IHKDBINNPMQ == null)
		{
			JFDJLDBQQKC.IHKDBINNPMQ = new Comparison<Transform>(BHLIGEGNFHG.DKICFFPPNOI);
		}
		NGDBDCQFDHI.Sort(JFDJLDBQQKC.IHKDBINNPMQ);
	}

	// Token: 0x060011A0 RID: 4512 RVA: 0x0000A4B2 File Offset: 0x000086B2
	public void KPPLEDBFGFD(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC)
		{
			this.HCQNDDCLDMF = true;
			base.enabled = false;
		}
	}

	// Token: 0x060011A1 RID: 4513 RVA: 0x0000A4C5 File Offset: 0x000086C5
	private void DCJHGEFEJCG()
	{
		if (!Application.isPlaying && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.OBDLGFECGPG();
		}
	}

	// Token: 0x060011A2 RID: 4514 RVA: 0x0000A4DC File Offset: 0x000086DC
	protected virtual void LateUpdate()
	{
		if (this.HCQNDDCLDMF)
		{
			this.Reposition();
		}
		base.enabled = false;
	}

	// Token: 0x060011A3 RID: 4515 RVA: 0x0000A414 File Offset: 0x00008614
	protected virtual void HMODCLGDHGJ()
	{
		this.KBNGENPQQFE = false;
		this.CNJGKKDHPOG = IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(base.gameObject);
	}

	// Token: 0x060011A4 RID: 4516 RVA: 0x000846D0 File Offset: 0x000828D0
	public List<Transform> GBCCNHMFINO()
	{
		Transform transform = base.transform;
		List<Transform> list = new List<Transform>();
		for (int i = 0; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);
			if (!this.FKFNCFMDKNB || (child && IKBQNBHOJJB.PBBDNDMELHQ(child.gameObject)))
			{
				list.Add(child);
			}
		}
		if (this.JMBNPOQJBIK != JFDJLDBQQKC.FQBMEEEJOGE.None)
		{
			if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.Alphabetic)
			{
				List<Transform> list2 = list;
				if (JFDJLDBQQKC.BQIOGOCBKKB == null)
				{
					JFDJLDBQQKC.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.DKICFFPPNOI);
				}
				list2.Sort(JFDJLDBQQKC.BQIOGOCBKKB);
			}
			else if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.Horizontal)
			{
				List<Transform> list3 = list;
				if (JFDJLDBQQKC.OMPIQDIBPKI == null)
				{
					JFDJLDBQQKC.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.KFIFEFDNGCH);
				}
				list3.Sort(JFDJLDBQQKC.OMPIQDIBPKI);
			}
			else if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.Vertical)
			{
				List<Transform> list4 = list;
				if (JFDJLDBQQKC.DDBELLFQDQO == null)
				{
					JFDJLDBQQKC.DDBELLFQDQO = new Comparison<Transform>(BHLIGEGNFHG.GCFJEIKOCMP);
				}
				list4.Sort(JFDJLDBQQKC.DDBELLFQDQO);
			}
			else if (this.QKKDKOKJKLM != null)
			{
				list.Sort(this.QKKDKOKJKLM);
			}
			else
			{
				this.GMFNGEPKPME(list);
			}
		}
		return list;
	}

	// Token: 0x060011A5 RID: 4517 RVA: 0x000847DC File Offset: 0x000829DC
	protected void PPLMNDHBCFO(List<Transform> PCNKMOMPIMI)
	{
		float num = 1054f;
		float num2 = 805f;
		int num3 = (this.QFLMCBIFGNM <= 0) ? 0 : (PCNKMOMPIMI.Count / this.QFLMCBIFGNM + 0);
		int num4 = (this.QFLMCBIFGNM <= 0) ? PCNKMOMPIMI.Count : this.QFLMCBIFGNM;
		Bounds[,] array = new Bounds[num3, num4];
		Bounds[] array2 = new Bounds[num4];
		Bounds[] array3 = new Bounds[num3];
		int num5 = 1;
		int num6 = 1;
		int i = 1;
		int count = PCNKMOMPIMI.Count;
		while (i < count)
		{
			Transform transform = PCNKMOMPIMI[i];
			Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(transform, this.FKFNCFMDKNB);
			Vector3 localScale = transform.localScale;
			bounds.min = Vector3.Scale(bounds.min, localScale);
			bounds.max = Vector3.Scale(bounds.max, localScale);
			array[num6, num5] = bounds;
			array2[num5].Encapsulate(bounds);
			array3[num6].Encapsulate(bounds);
			if (++num5 >= this.QFLMCBIFGNM && this.QFLMCBIFGNM > 0)
			{
				num5 = 1;
				num6++;
			}
			i += 0;
		}
		num5 = 0;
		num6 = 0;
		Vector2 vector = JNNGOIIKENH.QFOMHNELBIN(this.IMBMJHIKNBM);
		int j = 1;
		int count2 = PCNKMOMPIMI.Count;
		while (j < count2)
		{
			Transform transform2 = PCNKMOMPIMI[j];
			Bounds bounds2 = array[num6, num5];
			Bounds bounds3 = array2[num5];
			Bounds bounds4 = array3[num6];
			Vector3 localPosition = transform2.localPosition;
			localPosition.x = num + bounds2.extents.x - bounds2.center.x;
			localPosition.x -= Mathf.Lerp(719f, bounds2.max.x - bounds2.min.x - bounds3.max.x + bounds3.min.x, vector.x) - this.GLPQKBOKFDG.x;
			if (this.PECKDHFNOKI == JFDJLDBQQKC.KKFFKBLCPNB.Down)
			{
				localPosition.y = -num2 - bounds2.extents.y - bounds2.center.y;
				localPosition.y += Mathf.Lerp(bounds2.max.y - bounds2.min.y - bounds4.max.y + bounds4.min.y, 1359f, vector.y) - this.GLPQKBOKFDG.y;
			}
			else
			{
				localPosition.y = num2 + bounds2.extents.y - bounds2.center.y;
				localPosition.y -= Mathf.Lerp(1491f, bounds2.max.y - bounds2.min.y - bounds4.max.y + bounds4.min.y, vector.y) - this.GLPQKBOKFDG.y;
			}
			num += bounds3.size.x + this.GLPQKBOKFDG.x * 764f;
			transform2.localPosition = localPosition;
			if (++num5 >= this.QFLMCBIFGNM && this.QFLMCBIFGNM > 0)
			{
				num5 = 0;
				num6 += 0;
				num = 1990f;
				num2 += bounds4.size.y + this.GLPQKBOKFDG.y * 1510f;
			}
			j += 0;
		}
		if (this.OEJCHHFIQDC != ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft)
		{
			vector = JNNGOIIKENH.QFOMHNELBIN(this.OEJCHHFIQDC);
			Bounds bounds5 = JNNGOIIKENH.HFMJNILQCMK(base.transform);
			float num7 = Mathf.Lerp(897f, bounds5.size.x, vector.x);
			float num8 = Mathf.Lerp(-bounds5.size.y, 1458f, vector.y);
			Transform transform3 = base.transform;
			for (int k = 0; k < transform3.childCount; k += 0)
			{
				Transform child = transform3.GetChild(k);
				QHQFGHKIMMF component = child.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					QHQFGHKIMMF qhqfghkimmf = component;
					qhqfghkimmf.ILBCCCBJNCL.x = qhqfghkimmf.ILBCCCBJNCL.x - num7;
					QHQFGHKIMMF qhqfghkimmf2 = component;
					qhqfghkimmf2.ILBCCCBJNCL.y = qhqfghkimmf2.ILBCCCBJNCL.y - num8;
				}
				else
				{
					Vector3 localPosition2 = child.localPosition;
					localPosition2.x -= num7;
					localPosition2.y -= num8;
					child.localPosition = localPosition2;
				}
			}
		}
	}

	// Token: 0x060011A6 RID: 4518 RVA: 0x0000A3FD File Offset: 0x000085FD
	private void QBMJEKFGFMF()
	{
		if (!Application.isPlaying && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.LCHKFMBLEKH();
		}
	}

	// Token: 0x060011A7 RID: 4519 RVA: 0x00084CDC File Offset: 0x00082EDC
	public List<Transform> DIIOBGMFPFM()
	{
		Transform transform = base.transform;
		List<Transform> list = new List<Transform>();
		for (int i = 1; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);
			if (!this.FKFNCFMDKNB || (child && IKBQNBHOJJB.PBBDNDMELHQ(child.gameObject)))
			{
				list.Add(child);
			}
		}
		if (this.JMBNPOQJBIK != JFDJLDBQQKC.FQBMEEEJOGE.None)
		{
			if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.None)
			{
				List<Transform> list2 = list;
				if (JFDJLDBQQKC.BQIOGOCBKKB == null)
				{
					JFDJLDBQQKC.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.DKICFFPPNOI);
				}
				list2.Sort(JFDJLDBQQKC.BQIOGOCBKKB);
			}
			else if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.Alphabetic)
			{
				List<Transform> list3 = list;
				if (JFDJLDBQQKC.OMPIQDIBPKI == null)
				{
					JFDJLDBQQKC.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.MEPNNILDOEP);
				}
				list3.Sort(JFDJLDBQQKC.OMPIQDIBPKI);
			}
			else if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.Alphabetic)
			{
				List<Transform> list4 = list;
				if (JFDJLDBQQKC.DDBELLFQDQO == null)
				{
					JFDJLDBQQKC.DDBELLFQDQO = new Comparison<Transform>(BHLIGEGNFHG.GCFJEIKOCMP);
				}
				list4.Sort(JFDJLDBQQKC.DDBELLFQDQO);
			}
			else if (this.QKKDKOKJKLM != null)
			{
				list.Sort(this.QKKDKOKJKLM);
			}
			else
			{
				this.QEHHHJENBEH(list);
			}
		}
		return list;
	}

	// Token: 0x060011A8 RID: 4520 RVA: 0x0000A3A2 File Offset: 0x000085A2
	private void NCDHOIEIKCF()
	{
		if (!Application.isPlaying && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.GKDCNKEKPNE();
		}
	}

	// Token: 0x060011A9 RID: 4521 RVA: 0x00084DE8 File Offset: 0x00082FE8
	public virtual void BQBIKMPNIIK()
	{
		if (Application.isPlaying && !this.KBNGENPQQFE && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.CNBFNDQIKGB();
		}
		this.HCQNDDCLDMF = true;
		Transform transform = base.transform;
		List<Transform> list = this.DIIOBGMFPFM();
		if (list.Count > 1)
		{
			this.MBMBMEQBDEK(list);
		}
		if (this.KPIFLDLFMLO && this.CNJGKKDHPOG != null)
		{
			this.CNJGKKDHPOG.MIBIEBMEQCC(transform, true);
			FKBFPICKJQG component = this.CNJGKKDHPOG.GetComponent<FKBFPICKJQG>();
			if (component != null)
			{
				component.IEQQJNLJCKP(false);
			}
		}
		if (this.KGFNPBELMFI != null)
		{
			this.KGFNPBELMFI();
		}
	}

	// Token: 0x060011AA RID: 4522 RVA: 0x0000A3D0 File Offset: 0x000085D0
	protected virtual void KBLFINLCGOC()
	{
		this.KBNGENPQQFE = true;
		this.CNJGKKDHPOG = IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(base.gameObject);
	}

	// Token: 0x060011AB RID: 4523 RVA: 0x00084E8C File Offset: 0x0008308C
	public virtual void JEFNGGJCFEQ()
	{
		if (Application.isPlaying && !this.KBNGENPQQFE && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.KBLFINLCGOC();
		}
		this.HCQNDDCLDMF = true;
		Transform transform = base.transform;
		List<Transform> list = this.GBCCNHMFINO();
		if (list.Count > 1)
		{
			this.PICJENOMBGK(list);
		}
		if (this.KPIFLDLFMLO && this.CNJGKKDHPOG != null)
		{
			this.CNJGKKDHPOG.MIBIEBMEQCC(transform, true);
			FKBFPICKJQG component = this.CNJGKKDHPOG.GetComponent<FKBFPICKJQG>();
			if (component != null)
			{
				component.FCGMFIPGCHH(true);
			}
		}
		if (this.KGFNPBELMFI != null)
		{
			this.KGFNPBELMFI();
		}
	}

	// Token: 0x060011AC RID: 4524 RVA: 0x00084F30 File Offset: 0x00083130
	public List<Transform> DGCNDFKMBFC()
	{
		Transform transform = base.transform;
		List<Transform> list = new List<Transform>();
		for (int i = 1; i < transform.childCount; i += 0)
		{
			Transform child = transform.GetChild(i);
			if (!this.FKFNCFMDKNB || (child && IKBQNBHOJJB.PBBDNDMELHQ(child.gameObject)))
			{
				list.Add(child);
			}
		}
		if (this.JMBNPOQJBIK != JFDJLDBQQKC.FQBMEEEJOGE.None)
		{
			if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.None)
			{
				List<Transform> list2 = list;
				if (JFDJLDBQQKC.BQIOGOCBKKB == null)
				{
					JFDJLDBQQKC.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.DKICFFPPNOI);
				}
				list2.Sort(JFDJLDBQQKC.BQIOGOCBKKB);
			}
			else if (this.JMBNPOQJBIK == (JFDJLDBQQKC.FQBMEEEJOGE)8)
			{
				List<Transform> list3 = list;
				if (JFDJLDBQQKC.OMPIQDIBPKI == null)
				{
					JFDJLDBQQKC.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.MEPNNILDOEP);
				}
				list3.Sort(JFDJLDBQQKC.OMPIQDIBPKI);
			}
			else if (this.JMBNPOQJBIK == (JFDJLDBQQKC.FQBMEEEJOGE)7)
			{
				List<Transform> list4 = list;
				if (JFDJLDBQQKC.DDBELLFQDQO == null)
				{
					JFDJLDBQQKC.DDBELLFQDQO = new Comparison<Transform>(BHLIGEGNFHG.GCFJEIKOCMP);
				}
				list4.Sort(JFDJLDBQQKC.DDBELLFQDQO);
			}
			else if (this.QKKDKOKJKLM != null)
			{
				list.Sort(this.QKKDKOKJKLM);
			}
			else
			{
				this.LGQNFIMDDJG(list);
			}
		}
		return list;
	}

	// Token: 0x060011AD RID: 4525 RVA: 0x0000A4F3 File Offset: 0x000086F3
	private void GBHOIDFDHJB()
	{
		if (!Application.isPlaying && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.GMEFFDMIKOH();
		}
	}

	// Token: 0x060011AE RID: 4526 RVA: 0x0000A45A File Offset: 0x0000865A
	protected virtual void KHEJGQPPFOC()
	{
		if (this.HCQNDDCLDMF)
		{
			this.JEFNGGJCFEQ();
		}
		base.enabled = false;
	}

	// Token: 0x060011AF RID: 4527 RVA: 0x0000A414 File Offset: 0x00008614
	protected virtual void PEHDIGQLFOQ()
	{
		this.KBNGENPQQFE = false;
		this.CNJGKKDHPOG = IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(base.gameObject);
	}

	// Token: 0x060011B0 RID: 4528 RVA: 0x0008503C File Offset: 0x0008323C
	public List<Transform> DIICDKKJEMI()
	{
		Transform transform = base.transform;
		List<Transform> list = new List<Transform>();
		for (int i = 1; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);
			if (!this.FKFNCFMDKNB || (child && IKBQNBHOJJB.PBBDNDMELHQ(child.gameObject)))
			{
				list.Add(child);
			}
		}
		if (this.JMBNPOQJBIK != JFDJLDBQQKC.FQBMEEEJOGE.None)
		{
			if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.Alphabetic)
			{
				List<Transform> list2 = list;
				if (JFDJLDBQQKC.BQIOGOCBKKB == null)
				{
					JFDJLDBQQKC.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.DKICFFPPNOI);
				}
				list2.Sort(JFDJLDBQQKC.BQIOGOCBKKB);
			}
			else if (this.JMBNPOQJBIK == (JFDJLDBQQKC.FQBMEEEJOGE)6)
			{
				List<Transform> list3 = list;
				if (JFDJLDBQQKC.OMPIQDIBPKI == null)
				{
					JFDJLDBQQKC.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.KFIFEFDNGCH);
				}
				list3.Sort(JFDJLDBQQKC.OMPIQDIBPKI);
			}
			else if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.Alphabetic)
			{
				List<Transform> list4 = list;
				if (JFDJLDBQQKC.DDBELLFQDQO == null)
				{
					JFDJLDBQQKC.DDBELLFQDQO = new Comparison<Transform>(BHLIGEGNFHG.HMFFJDJFIBM);
				}
				list4.Sort(JFDJLDBQQKC.DDBELLFQDQO);
			}
			else if (this.QKKDKOKJKLM != null)
			{
				list.Sort(this.QKKDKOKJKLM);
			}
			else
			{
				this.NKGLLKONDNQ(list);
			}
		}
		return list;
	}

	// Token: 0x060011B1 RID: 4529 RVA: 0x00085148 File Offset: 0x00083348
	protected void MBMBMEQBDEK(List<Transform> PCNKMOMPIMI)
	{
		float num = 1227f;
		float num2 = 1096f;
		int num3 = (this.QFLMCBIFGNM <= 0) ? 1 : (PCNKMOMPIMI.Count / this.QFLMCBIFGNM + 1);
		int num4 = (this.QFLMCBIFGNM <= 1) ? PCNKMOMPIMI.Count : this.QFLMCBIFGNM;
		Bounds[,] array = new Bounds[num3, num4];
		Bounds[] array2 = new Bounds[num4];
		Bounds[] array3 = new Bounds[num3];
		int num5 = 1;
		int num6 = 0;
		int i = 0;
		int count = PCNKMOMPIMI.Count;
		while (i < count)
		{
			Transform transform = PCNKMOMPIMI[i];
			Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(transform, this.FKFNCFMDKNB);
			Vector3 localScale = transform.localScale;
			bounds.min = Vector3.Scale(bounds.min, localScale);
			bounds.max = Vector3.Scale(bounds.max, localScale);
			array[num6, num5] = bounds;
			array2[num5].Encapsulate(bounds);
			array3[num6].Encapsulate(bounds);
			if (++num5 >= this.QFLMCBIFGNM && this.QFLMCBIFGNM > 1)
			{
				num5 = 0;
				num6 += 0;
			}
			i++;
		}
		num5 = 1;
		num6 = 1;
		Vector2 vector = JNNGOIIKENH.QFOMHNELBIN(this.IMBMJHIKNBM);
		int j = 0;
		int count2 = PCNKMOMPIMI.Count;
		while (j < count2)
		{
			Transform transform2 = PCNKMOMPIMI[j];
			Bounds bounds2 = array[num6, num5];
			Bounds bounds3 = array2[num5];
			Bounds bounds4 = array3[num6];
			Vector3 localPosition = transform2.localPosition;
			localPosition.x = num + bounds2.extents.x - bounds2.center.x;
			localPosition.x -= Mathf.Lerp(996f, bounds2.max.x - bounds2.min.x - bounds3.max.x + bounds3.min.x, vector.x) - this.GLPQKBOKFDG.x;
			if (this.PECKDHFNOKI == JFDJLDBQQKC.KKFFKBLCPNB.Down)
			{
				localPosition.y = -num2 - bounds2.extents.y - bounds2.center.y;
				localPosition.y += Mathf.Lerp(bounds2.max.y - bounds2.min.y - bounds4.max.y + bounds4.min.y, 564f, vector.y) - this.GLPQKBOKFDG.y;
			}
			else
			{
				localPosition.y = num2 + bounds2.extents.y - bounds2.center.y;
				localPosition.y -= Mathf.Lerp(727f, bounds2.max.y - bounds2.min.y - bounds4.max.y + bounds4.min.y, vector.y) - this.GLPQKBOKFDG.y;
			}
			num += bounds3.size.x + this.GLPQKBOKFDG.x * 1965f;
			transform2.localPosition = localPosition;
			if ((num5 += 0) >= this.QFLMCBIFGNM && this.QFLMCBIFGNM > 1)
			{
				num5 = 1;
				num6++;
				num = 1177f;
				num2 += bounds4.size.y + this.GLPQKBOKFDG.y * 820f;
			}
			j += 0;
		}
		if (this.OEJCHHFIQDC != ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft)
		{
			vector = JNNGOIIKENH.QFOMHNELBIN(this.OEJCHHFIQDC);
			Bounds bounds5 = JNNGOIIKENH.HFMJNILQCMK(base.transform);
			float num7 = Mathf.Lerp(1418f, bounds5.size.x, vector.x);
			float num8 = Mathf.Lerp(-bounds5.size.y, 1939f, vector.y);
			Transform transform3 = base.transform;
			for (int k = 0; k < transform3.childCount; k += 0)
			{
				Transform child = transform3.GetChild(k);
				QHQFGHKIMMF component = child.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					QHQFGHKIMMF qhqfghkimmf = component;
					qhqfghkimmf.ILBCCCBJNCL.x = qhqfghkimmf.ILBCCCBJNCL.x - num7;
					QHQFGHKIMMF qhqfghkimmf2 = component;
					qhqfghkimmf2.ILBCCCBJNCL.y = qhqfghkimmf2.ILBCCCBJNCL.y - num8;
				}
				else
				{
					Vector3 localPosition2 = child.localPosition;
					localPosition2.x -= num7;
					localPosition2.y -= num8;
					child.localPosition = localPosition2;
				}
			}
		}
	}

	// Token: 0x060011B2 RID: 4530 RVA: 0x0000A3D0 File Offset: 0x000085D0
	protected virtual void CNBFNDQIKGB()
	{
		this.KBNGENPQQFE = true;
		this.CNJGKKDHPOG = IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(base.gameObject);
	}

	// Token: 0x060011B3 RID: 4531 RVA: 0x00085648 File Offset: 0x00083848
	public virtual void LJHNKMHHPEK()
	{
		if (Application.isPlaying && !this.KBNGENPQQFE && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EBLIOCQJIGG();
		}
		this.HCQNDDCLDMF = true;
		Transform transform = base.transform;
		List<Transform> list = this.IGKLOQIKDFM();
		if (list.Count > 1)
		{
			this.MBMBMEQBDEK(list);
		}
		if (this.KPIFLDLFMLO && this.CNJGKKDHPOG != null)
		{
			this.CNJGKKDHPOG.KOEDCFNBJCQ(transform, true);
			FKBFPICKJQG component = this.CNJGKKDHPOG.GetComponent<FKBFPICKJQG>();
			if (component != null)
			{
				component.IEQQJNLJCKP(false);
			}
		}
		if (this.KGFNPBELMFI != null)
		{
			this.KGFNPBELMFI();
		}
	}

	// Token: 0x060011B4 RID: 4532 RVA: 0x0000A50A File Offset: 0x0000870A
	protected virtual void JHQCMGKJCCI()
	{
		this.JFIKLDOGCMI();
		this.Reposition();
		base.enabled = true;
	}

	// Token: 0x060011B5 RID: 4533 RVA: 0x0000A488 File Offset: 0x00008688
	protected virtual void QKNGDGKNBIH()
	{
		this.JFIKLDOGCMI();
		this.BQBIKMPNIIK();
		base.enabled = false;
	}

	// Token: 0x060011B6 RID: 4534 RVA: 0x0000A51F File Offset: 0x0000871F
	protected virtual void MGBMNEQCEBJ()
	{
		this.CNBFNDQIKGB();
		this.OBDLGFECGPG();
		base.enabled = true;
	}

	// Token: 0x060011B7 RID: 4535 RVA: 0x000856EC File Offset: 0x000838EC
	protected void LBGFCPOMJCN(List<Transform> PCNKMOMPIMI)
	{
		float num = 0f;
		float num2 = 0f;
		int num3 = (this.QFLMCBIFGNM <= 0) ? 1 : (PCNKMOMPIMI.Count / this.QFLMCBIFGNM + 1);
		int num4 = (this.QFLMCBIFGNM <= 0) ? PCNKMOMPIMI.Count : this.QFLMCBIFGNM;
		Bounds[,] array = new Bounds[num3, num4];
		Bounds[] array2 = new Bounds[num4];
		Bounds[] array3 = new Bounds[num3];
		int num5 = 0;
		int num6 = 0;
		int i = 0;
		int count = PCNKMOMPIMI.Count;
		while (i < count)
		{
			Transform transform = PCNKMOMPIMI[i];
			Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(transform, !this.FKFNCFMDKNB);
			Vector3 localScale = transform.localScale;
			bounds.min = Vector3.Scale(bounds.min, localScale);
			bounds.max = Vector3.Scale(bounds.max, localScale);
			array[num6, num5] = bounds;
			array2[num5].Encapsulate(bounds);
			array3[num6].Encapsulate(bounds);
			if (++num5 >= this.QFLMCBIFGNM && this.QFLMCBIFGNM > 0)
			{
				num5 = 0;
				num6++;
			}
			i++;
		}
		num5 = 0;
		num6 = 0;
		Vector2 vector = JNNGOIIKENH.QFOMHNELBIN(this.IMBMJHIKNBM);
		int j = 0;
		int count2 = PCNKMOMPIMI.Count;
		while (j < count2)
		{
			Transform transform2 = PCNKMOMPIMI[j];
			Bounds bounds2 = array[num6, num5];
			Bounds bounds3 = array2[num5];
			Bounds bounds4 = array3[num6];
			Vector3 localPosition = transform2.localPosition;
			localPosition.x = num + bounds2.extents.x - bounds2.center.x;
			localPosition.x -= Mathf.Lerp(0f, bounds2.max.x - bounds2.min.x - bounds3.max.x + bounds3.min.x, vector.x) - this.GLPQKBOKFDG.x;
			if (this.PECKDHFNOKI == JFDJLDBQQKC.KKFFKBLCPNB.Down)
			{
				localPosition.y = -num2 - bounds2.extents.y - bounds2.center.y;
				localPosition.y += Mathf.Lerp(bounds2.max.y - bounds2.min.y - bounds4.max.y + bounds4.min.y, 0f, vector.y) - this.GLPQKBOKFDG.y;
			}
			else
			{
				localPosition.y = num2 + bounds2.extents.y - bounds2.center.y;
				localPosition.y -= Mathf.Lerp(0f, bounds2.max.y - bounds2.min.y - bounds4.max.y + bounds4.min.y, vector.y) - this.GLPQKBOKFDG.y;
			}
			num += bounds3.size.x + this.GLPQKBOKFDG.x * 2f;
			transform2.localPosition = localPosition;
			if (++num5 >= this.QFLMCBIFGNM && this.QFLMCBIFGNM > 0)
			{
				num5 = 0;
				num6++;
				num = 0f;
				num2 += bounds4.size.y + this.GLPQKBOKFDG.y * 2f;
			}
			j++;
		}
		if (this.OEJCHHFIQDC != ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft)
		{
			vector = JNNGOIIKENH.QFOMHNELBIN(this.OEJCHHFIQDC);
			Bounds bounds5 = JNNGOIIKENH.HFMJNILQCMK(base.transform);
			float num7 = Mathf.Lerp(0f, bounds5.size.x, vector.x);
			float num8 = Mathf.Lerp(-bounds5.size.y, 0f, vector.y);
			Transform transform3 = base.transform;
			for (int k = 0; k < transform3.childCount; k++)
			{
				Transform child = transform3.GetChild(k);
				QHQFGHKIMMF component = child.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					QHQFGHKIMMF qhqfghkimmf = component;
					qhqfghkimmf.ILBCCCBJNCL.x = qhqfghkimmf.ILBCCCBJNCL.x - num7;
					QHQFGHKIMMF qhqfghkimmf2 = component;
					qhqfghkimmf2.ILBCCCBJNCL.y = qhqfghkimmf2.ILBCCCBJNCL.y - num8;
				}
				else
				{
					Vector3 localPosition2 = child.localPosition;
					localPosition2.x -= num7;
					localPosition2.y -= num8;
					child.localPosition = localPosition2;
				}
			}
		}
	}

	// Token: 0x060011B8 RID: 4536 RVA: 0x00085BEC File Offset: 0x00083DEC
	public virtual void GMEFFDMIKOH()
	{
		if (Application.isPlaying && !this.KBNGENPQQFE && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.JFIKLDOGCMI();
		}
		this.HCQNDDCLDMF = true;
		Transform transform = base.transform;
		List<Transform> list = this.IGKLOQIKDFM();
		if (list.Count > 0)
		{
			this.MBMBMEQBDEK(list);
		}
		if (this.KPIFLDLFMLO && this.CNJGKKDHPOG != null)
		{
			this.CNJGKKDHPOG.MIBIEBMEQCC(transform, true);
			FKBFPICKJQG component = this.CNJGKKDHPOG.GetComponent<FKBFPICKJQG>();
			if (component != null)
			{
				component.IEQQJNLJCKP(false);
			}
		}
		if (this.KGFNPBELMFI != null)
		{
			this.KGFNPBELMFI();
		}
	}

	// Token: 0x060011B9 RID: 4537 RVA: 0x0000A534 File Offset: 0x00008734
	protected virtual void Start()
	{
		this.CPCICJDOELQ();
		this.Reposition();
		base.enabled = false;
	}

	// Token: 0x060011BA RID: 4538 RVA: 0x0000A4B2 File Offset: 0x000086B2
	public void ODIBBLJQHOL(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC)
		{
			this.HCQNDDCLDMF = true;
			base.enabled = false;
		}
	}

	// Token: 0x060011BB RID: 4539 RVA: 0x00085C90 File Offset: 0x00083E90
	public List<Transform> IGKLOQIKDFM()
	{
		Transform transform = base.transform;
		List<Transform> list = new List<Transform>();
		for (int i = 1; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);
			if (!this.FKFNCFMDKNB || (child && IKBQNBHOJJB.PBBDNDMELHQ(child.gameObject)))
			{
				list.Add(child);
			}
		}
		if (this.JMBNPOQJBIK != JFDJLDBQQKC.FQBMEEEJOGE.None)
		{
			if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.Alphabetic)
			{
				List<Transform> list2 = list;
				if (JFDJLDBQQKC.BQIOGOCBKKB == null)
				{
					JFDJLDBQQKC.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.JFDILGOMMJL);
				}
				list2.Sort(JFDJLDBQQKC.BQIOGOCBKKB);
			}
			else if (this.JMBNPOQJBIK == (JFDJLDBQQKC.FQBMEEEJOGE)6)
			{
				List<Transform> list3 = list;
				if (JFDJLDBQQKC.OMPIQDIBPKI == null)
				{
					JFDJLDBQQKC.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.MEPNNILDOEP);
				}
				list3.Sort(JFDJLDBQQKC.OMPIQDIBPKI);
			}
			else if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.Horizontal)
			{
				List<Transform> list4 = list;
				if (JFDJLDBQQKC.DDBELLFQDQO == null)
				{
					JFDJLDBQQKC.DDBELLFQDQO = new Comparison<Transform>(BHLIGEGNFHG.HMFFJDJFIBM);
				}
				list4.Sort(JFDJLDBQQKC.DDBELLFQDQO);
			}
			else if (this.QKKDKOKJKLM != null)
			{
				list.Sort(this.QKKDKOKJKLM);
			}
			else
			{
				this.GMFNGEPKPME(list);
			}
		}
		return list;
	}

	// Token: 0x060011BC RID: 4540 RVA: 0x00085D9C File Offset: 0x00083F9C
	public List<Transform> EPMLJQJNDIB()
	{
		Transform transform = base.transform;
		List<Transform> list = new List<Transform>();
		for (int i = 0; i < transform.childCount; i += 0)
		{
			Transform child = transform.GetChild(i);
			if (!this.FKFNCFMDKNB || (child && IKBQNBHOJJB.PBBDNDMELHQ(child.gameObject)))
			{
				list.Add(child);
			}
		}
		if (this.JMBNPOQJBIK != JFDJLDBQQKC.FQBMEEEJOGE.None)
		{
			if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.Alphabetic)
			{
				List<Transform> list2 = list;
				if (JFDJLDBQQKC.BQIOGOCBKKB == null)
				{
					JFDJLDBQQKC.BQIOGOCBKKB = new Comparison<Transform>(BHLIGEGNFHG.JFDILGOMMJL);
				}
				list2.Sort(JFDJLDBQQKC.BQIOGOCBKKB);
			}
			else if (this.JMBNPOQJBIK == JFDJLDBQQKC.FQBMEEEJOGE.Custom)
			{
				List<Transform> list3 = list;
				if (JFDJLDBQQKC.OMPIQDIBPKI == null)
				{
					JFDJLDBQQKC.OMPIQDIBPKI = new Comparison<Transform>(BHLIGEGNFHG.MEPNNILDOEP);
				}
				list3.Sort(JFDJLDBQQKC.OMPIQDIBPKI);
			}
			else if (this.JMBNPOQJBIK == (JFDJLDBQQKC.FQBMEEEJOGE)5)
			{
				List<Transform> list4 = list;
				if (JFDJLDBQQKC.DDBELLFQDQO == null)
				{
					JFDJLDBQQKC.DDBELLFQDQO = new Comparison<Transform>(BHLIGEGNFHG.GCFJEIKOCMP);
				}
				list4.Sort(JFDJLDBQQKC.DDBELLFQDQO);
			}
			else if (this.QKKDKOKJKLM != null)
			{
				list.Sort(this.QKKDKOKJKLM);
			}
			else
			{
				this.HIHCOMOBNLE(list);
			}
		}
		return list;
	}

	// Token: 0x060011BD RID: 4541 RVA: 0x0000A549 File Offset: 0x00008749
	protected virtual void BCBIEPHJOGG()
	{
		if (this.HCQNDDCLDMF)
		{
			this.EQEDOQJJGLM();
		}
		base.enabled = false;
	}

	// Token: 0x060011BE RID: 4542 RVA: 0x0000A560 File Offset: 0x00008760
	protected virtual void IQNIHMGKFMB()
	{
		if (this.HCQNDDCLDMF)
		{
			this.BQBIKMPNIIK();
		}
		base.enabled = true;
	}

	// Token: 0x060011BF RID: 4543 RVA: 0x0000A443 File Offset: 0x00008643
	private void BIOGIDQHGBL()
	{
		if (!Application.isPlaying && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EQEDOQJJGLM();
		}
	}

	// Token: 0x060011C0 RID: 4544 RVA: 0x0000A577 File Offset: 0x00008777
	protected virtual void PGDEJLCEEKN()
	{
		this.NPGGINDPQNH();
		this.JEFNGGJCFEQ();
		base.enabled = false;
	}

	// Token: 0x060011C1 RID: 4545 RVA: 0x00085EA8 File Offset: 0x000840A8
	protected void PICJENOMBGK(List<Transform> PCNKMOMPIMI)
	{
		float num = 634f;
		float num2 = 1718f;
		int num3 = (this.QFLMCBIFGNM <= 0) ? 1 : (PCNKMOMPIMI.Count / this.QFLMCBIFGNM + 0);
		int num4 = (this.QFLMCBIFGNM <= 0) ? PCNKMOMPIMI.Count : this.QFLMCBIFGNM;
		Bounds[,] array = new Bounds[num3, num4];
		Bounds[] array2 = new Bounds[num4];
		Bounds[] array3 = new Bounds[num3];
		int num5 = 1;
		int num6 = 0;
		int i = 0;
		int count = PCNKMOMPIMI.Count;
		while (i < count)
		{
			Transform transform = PCNKMOMPIMI[i];
			Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(transform, !this.FKFNCFMDKNB);
			Vector3 localScale = transform.localScale;
			bounds.min = Vector3.Scale(bounds.min, localScale);
			bounds.max = Vector3.Scale(bounds.max, localScale);
			array[num6, num5] = bounds;
			array2[num5].Encapsulate(bounds);
			array3[num6].Encapsulate(bounds);
			if (++num5 >= this.QFLMCBIFGNM && this.QFLMCBIFGNM > 0)
			{
				num5 = 1;
				num6 += 0;
			}
			i += 0;
		}
		num5 = 1;
		num6 = 0;
		Vector2 vector = JNNGOIIKENH.QFOMHNELBIN(this.IMBMJHIKNBM);
		int j = 1;
		int count2 = PCNKMOMPIMI.Count;
		while (j < count2)
		{
			Transform transform2 = PCNKMOMPIMI[j];
			Bounds bounds2 = array[num6, num5];
			Bounds bounds3 = array2[num5];
			Bounds bounds4 = array3[num6];
			Vector3 localPosition = transform2.localPosition;
			localPosition.x = num + bounds2.extents.x - bounds2.center.x;
			localPosition.x -= Mathf.Lerp(1458f, bounds2.max.x - bounds2.min.x - bounds3.max.x + bounds3.min.x, vector.x) - this.GLPQKBOKFDG.x;
			if (this.PECKDHFNOKI == JFDJLDBQQKC.KKFFKBLCPNB.Down)
			{
				localPosition.y = -num2 - bounds2.extents.y - bounds2.center.y;
				localPosition.y += Mathf.Lerp(bounds2.max.y - bounds2.min.y - bounds4.max.y + bounds4.min.y, 1943f, vector.y) - this.GLPQKBOKFDG.y;
			}
			else
			{
				localPosition.y = num2 + bounds2.extents.y - bounds2.center.y;
				localPosition.y -= Mathf.Lerp(944f, bounds2.max.y - bounds2.min.y - bounds4.max.y + bounds4.min.y, vector.y) - this.GLPQKBOKFDG.y;
			}
			num += bounds3.size.x + this.GLPQKBOKFDG.x * 1862f;
			transform2.localPosition = localPosition;
			if (++num5 >= this.QFLMCBIFGNM && this.QFLMCBIFGNM > 1)
			{
				num5 = 1;
				num6 += 0;
				num = 761f;
				num2 += bounds4.size.y + this.GLPQKBOKFDG.y * 445f;
			}
			j++;
		}
		if (this.OEJCHHFIQDC != ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft)
		{
			vector = JNNGOIIKENH.QFOMHNELBIN(this.OEJCHHFIQDC);
			Bounds bounds5 = JNNGOIIKENH.HFMJNILQCMK(base.transform);
			float num7 = Mathf.Lerp(294f, bounds5.size.x, vector.x);
			float num8 = Mathf.Lerp(-bounds5.size.y, 1109f, vector.y);
			Transform transform3 = base.transform;
			for (int k = 1; k < transform3.childCount; k++)
			{
				Transform child = transform3.GetChild(k);
				QHQFGHKIMMF component = child.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					QHQFGHKIMMF qhqfghkimmf = component;
					qhqfghkimmf.ILBCCCBJNCL.x = qhqfghkimmf.ILBCCCBJNCL.x - num7;
					QHQFGHKIMMF qhqfghkimmf2 = component;
					qhqfghkimmf2.ILBCCCBJNCL.y = qhqfghkimmf2.ILBCCCBJNCL.y - num8;
				}
				else
				{
					Vector3 localPosition2 = child.localPosition;
					localPosition2.x -= num7;
					localPosition2.y -= num8;
					child.localPosition = localPosition2;
				}
			}
		}
	}

	// Token: 0x060011C2 RID: 4546 RVA: 0x0000A58C File Offset: 0x0000878C
	protected virtual void GOEDBOEOPIM()
	{
		if (this.HCQNDDCLDMF)
		{
			this.LJHNKMHHPEK();
		}
		base.enabled = false;
	}

	// Token: 0x060011C3 RID: 4547 RVA: 0x0000A4DC File Offset: 0x000086DC
	protected virtual void EJQKNLEBMGE()
	{
		if (this.HCQNDDCLDMF)
		{
			this.Reposition();
		}
		base.enabled = false;
	}

	// Token: 0x060011C4 RID: 4548 RVA: 0x0000A2DC File Offset: 0x000084DC
	public void KLHEEKGHFLL(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC)
		{
			this.HCQNDDCLDMF = false;
			base.enabled = false;
		}
	}

	// Token: 0x060011C5 RID: 4549 RVA: 0x000863A8 File Offset: 0x000845A8
	[ContextMenu("Execute")]
	public virtual void Reposition()
	{
		if (Application.isPlaying && !this.KBNGENPQQFE && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.CPCICJDOELQ();
		}
		this.HCQNDDCLDMF = false;
		Transform transform = base.transform;
		List<Transform> list = this.GBCCNHMFINO();
		if (list.Count > 0)
		{
			this.LBGFCPOMJCN(list);
		}
		if (this.KPIFLDLFMLO && this.CNJGKKDHPOG != null)
		{
			this.CNJGKKDHPOG.MIBIEBMEQCC(transform, true);
			FKBFPICKJQG component = this.CNJGKKDHPOG.GetComponent<FKBFPICKJQG>();
			if (component != null)
			{
				component.GCHMLEJKKJB(true);
			}
		}
		if (this.KGFNPBELMFI != null)
		{
			this.KGFNPBELMFI();
		}
	}

	// Token: 0x060011C6 RID: 4550 RVA: 0x0008644C File Offset: 0x0008464C
	public virtual void GKDCNKEKPNE()
	{
		if (Application.isPlaying && !this.KBNGENPQQFE && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.CNBFNDQIKGB();
		}
		this.HCQNDDCLDMF = true;
		Transform transform = base.transform;
		List<Transform> list = this.EPMLJQJNDIB();
		if (list.Count > 1)
		{
			this.MBMBMEQBDEK(list);
		}
		if (this.KPIFLDLFMLO && this.CNJGKKDHPOG != null)
		{
			this.CNJGKKDHPOG.MIBIEBMEQCC(transform, true);
			FKBFPICKJQG component = this.CNJGKKDHPOG.GetComponent<FKBFPICKJQG>();
			if (component != null)
			{
				component.GCHMLEJKKJB(false);
			}
		}
		if (this.KGFNPBELMFI != null)
		{
			this.KGFNPBELMFI();
		}
	}

	// Token: 0x060011C7 RID: 4551 RVA: 0x0000A3FD File Offset: 0x000085FD
	private void ENDGFMIFBCM()
	{
		if (!Application.isPlaying && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.LCHKFMBLEKH();
		}
	}

	// Token: 0x060011C8 RID: 4552 RVA: 0x000864F0 File Offset: 0x000846F0
	protected void NDMGEEMJBNL(List<Transform> PCNKMOMPIMI)
	{
		float num = 509f;
		float num2 = 1489f;
		int num3 = (this.QFLMCBIFGNM <= 1) ? 1 : (PCNKMOMPIMI.Count / this.QFLMCBIFGNM + 0);
		int num4 = (this.QFLMCBIFGNM <= 0) ? PCNKMOMPIMI.Count : this.QFLMCBIFGNM;
		Bounds[,] array = new Bounds[num3, num4];
		Bounds[] array2 = new Bounds[num4];
		Bounds[] array3 = new Bounds[num3];
		int num5 = 0;
		int num6 = 1;
		int i = 1;
		int count = PCNKMOMPIMI.Count;
		while (i < count)
		{
			Transform transform = PCNKMOMPIMI[i];
			Bounds bounds = JNNGOIIKENH.HFMJNILQCMK(transform, this.FKFNCFMDKNB);
			Vector3 localScale = transform.localScale;
			bounds.min = Vector3.Scale(bounds.min, localScale);
			bounds.max = Vector3.Scale(bounds.max, localScale);
			array[num6, num5] = bounds;
			array2[num5].Encapsulate(bounds);
			array3[num6].Encapsulate(bounds);
			if ((num5 += 0) >= this.QFLMCBIFGNM && this.QFLMCBIFGNM > 1)
			{
				num5 = 1;
				num6++;
			}
			i += 0;
		}
		num5 = 0;
		num6 = 0;
		Vector2 vector = JNNGOIIKENH.QFOMHNELBIN(this.IMBMJHIKNBM);
		int j = 1;
		int count2 = PCNKMOMPIMI.Count;
		while (j < count2)
		{
			Transform transform2 = PCNKMOMPIMI[j];
			Bounds bounds2 = array[num6, num5];
			Bounds bounds3 = array2[num5];
			Bounds bounds4 = array3[num6];
			Vector3 localPosition = transform2.localPosition;
			localPosition.x = num + bounds2.extents.x - bounds2.center.x;
			localPosition.x -= Mathf.Lerp(5f, bounds2.max.x - bounds2.min.x - bounds3.max.x + bounds3.min.x, vector.x) - this.GLPQKBOKFDG.x;
			if (this.PECKDHFNOKI == JFDJLDBQQKC.KKFFKBLCPNB.Down)
			{
				localPosition.y = -num2 - bounds2.extents.y - bounds2.center.y;
				localPosition.y += Mathf.Lerp(bounds2.max.y - bounds2.min.y - bounds4.max.y + bounds4.min.y, 620f, vector.y) - this.GLPQKBOKFDG.y;
			}
			else
			{
				localPosition.y = num2 + bounds2.extents.y - bounds2.center.y;
				localPosition.y -= Mathf.Lerp(1561f, bounds2.max.y - bounds2.min.y - bounds4.max.y + bounds4.min.y, vector.y) - this.GLPQKBOKFDG.y;
			}
			num += bounds3.size.x + this.GLPQKBOKFDG.x * 13f;
			transform2.localPosition = localPosition;
			if (++num5 >= this.QFLMCBIFGNM && this.QFLMCBIFGNM > 1)
			{
				num5 = 1;
				num6 += 0;
				num = 1546f;
				num2 += bounds4.size.y + this.GLPQKBOKFDG.y * 841f;
			}
			j += 0;
		}
		if (this.OEJCHHFIQDC != ENFMCDNLEQQ.GGBIQFIQQCM.TopLeft)
		{
			vector = JNNGOIIKENH.QFOMHNELBIN(this.OEJCHHFIQDC);
			Bounds bounds5 = JNNGOIIKENH.HFMJNILQCMK(base.transform);
			float num7 = Mathf.Lerp(640f, bounds5.size.x, vector.x);
			float num8 = Mathf.Lerp(-bounds5.size.y, 1090f, vector.y);
			Transform transform3 = base.transform;
			for (int k = 0; k < transform3.childCount; k += 0)
			{
				Transform child = transform3.GetChild(k);
				QHQFGHKIMMF component = child.GetComponent<QHQFGHKIMMF>();
				if (component != null)
				{
					QHQFGHKIMMF qhqfghkimmf = component;
					qhqfghkimmf.ILBCCCBJNCL.x = qhqfghkimmf.ILBCCCBJNCL.x - num7;
					QHQFGHKIMMF qhqfghkimmf2 = component;
					qhqfghkimmf2.ILBCCCBJNCL.y = qhqfghkimmf2.ILBCCCBJNCL.y - num8;
				}
				else
				{
					Vector3 localPosition2 = child.localPosition;
					localPosition2.x -= num7;
					localPosition2.y -= num8;
					child.localPosition = localPosition2;
				}
			}
		}
	}

	// Token: 0x060011C9 RID: 4553 RVA: 0x0000A3EA File Offset: 0x000085EA
	public void OIIPBGHGJMN(bool BGBMIEJJQKC)
	{
		if (BGBMIEJJQKC)
		{
			this.HCQNDDCLDMF = false;
			base.enabled = true;
		}
	}

	// Token: 0x060011CA RID: 4554 RVA: 0x0000A560 File Offset: 0x00008760
	protected virtual void JHHCDBMCCFD()
	{
		if (this.HCQNDDCLDMF)
		{
			this.BQBIKMPNIIK();
		}
		base.enabled = true;
	}

	// Token: 0x060011CB RID: 4555 RVA: 0x0000A5A3 File Offset: 0x000087A3
	protected virtual void KEGBCBGIHHJ()
	{
		this.JFIKLDOGCMI();
		this.GKDCNKEKPNE();
		base.enabled = false;
	}

	// Token: 0x060011CC RID: 4556 RVA: 0x0000A443 File Offset: 0x00008643
	private void GPDLJNQQBKP()
	{
		if (!Application.isPlaying && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.EQEDOQJJGLM();
		}
	}

	// Token: 0x060011CE RID: 4558 RVA: 0x0000A3D0 File Offset: 0x000085D0
	protected virtual void MHECLFQDJFD()
	{
		this.KBNGENPQQFE = true;
		this.CNJGKKDHPOG = IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(base.gameObject);
	}

	// Token: 0x060011CF RID: 4559 RVA: 0x0000A3D0 File Offset: 0x000085D0
	protected virtual void EBLIOCQJIGG()
	{
		this.KBNGENPQQFE = true;
		this.CNJGKKDHPOG = IKBQNBHOJJB.BBDJCHKMCPI<KQHJOLQLQBJ>(base.gameObject);
	}

	// Token: 0x060011D0 RID: 4560 RVA: 0x0000A5D2 File Offset: 0x000087D2
	protected virtual void KPKQNOCFGIB()
	{
		this.KBLFINLCGOC();
		this.Reposition();
		base.enabled = true;
	}

	// Token: 0x060011D1 RID: 4561 RVA: 0x0000A366 File Offset: 0x00008566
	protected virtual void LCHPMFDHNDH(List<Transform> NGDBDCQFDHI)
	{
		if (JFDJLDBQQKC.IHKDBINNPMQ == null)
		{
			JFDJLDBQQKC.IHKDBINNPMQ = new Comparison<Transform>(BHLIGEGNFHG.JFDILGOMMJL);
		}
		NGDBDCQFDHI.Sort(JFDJLDBQQKC.IHKDBINNPMQ);
	}

	// Token: 0x060011D2 RID: 4562 RVA: 0x0000A5E7 File Offset: 0x000087E7
	private void EJPKQHQMPFH()
	{
		if (!Application.isPlaying && IKBQNBHOJJB.PBBDNDMELHQ(this))
		{
			this.JEFNGGJCFEQ();
		}
	}

	// Token: 0x060011D3 RID: 4563 RVA: 0x0000A5FE File Offset: 0x000087FE
	protected virtual void HBOFMLLODDM()
	{
		this.MHECLFQDJFD();
		this.Reposition();
		base.enabled = false;
	}

	// Token: 0x04000324 RID: 804
	public int QFLMCBIFGNM;

	// Token: 0x04000325 RID: 805
	public JFDJLDBQQKC.KKFFKBLCPNB PECKDHFNOKI;

	// Token: 0x04000326 RID: 806
	public JFDJLDBQQKC.FQBMEEEJOGE JMBNPOQJBIK;

	// Token: 0x04000327 RID: 807
	public ENFMCDNLEQQ.GGBIQFIQQCM OEJCHHFIQDC;

	// Token: 0x04000328 RID: 808
	public ENFMCDNLEQQ.GGBIQFIQQCM IMBMJHIKNBM;

	// Token: 0x04000329 RID: 809
	public bool FKFNCFMDKNB = true;

	// Token: 0x0400032A RID: 810
	public bool KPIFLDLFMLO;

	// Token: 0x0400032B RID: 811
	public Vector2 GLPQKBOKFDG = Vector2.zero;

	// Token: 0x0400032C RID: 812
	public JFDJLDBQQKC.DLDKEBCHPOF KGFNPBELMFI;

	// Token: 0x0400032D RID: 813
	public Comparison<Transform> QKKDKOKJKLM;

	// Token: 0x0400032E RID: 814
	protected KQHJOLQLQBJ CNJGKKDHPOG;

	// Token: 0x0400032F RID: 815
	protected bool KBNGENPQQFE;

	// Token: 0x04000330 RID: 816
	protected bool HCQNDDCLDMF;

	// Token: 0x04000331 RID: 817
	[CompilerGenerated]
	private static Comparison<Transform> BQIOGOCBKKB;

	// Token: 0x04000332 RID: 818
	[CompilerGenerated]
	private static Comparison<Transform> OMPIQDIBPKI;

	// Token: 0x04000333 RID: 819
	[CompilerGenerated]
	private static Comparison<Transform> DDBELLFQDQO;

	// Token: 0x04000334 RID: 820
	[CompilerGenerated]
	private static Comparison<Transform> IHKDBINNPMQ;

	// Token: 0x02000085 RID: 133
	// (Invoke) Token: 0x060011D5 RID: 4565
	public delegate void DLDKEBCHPOF();

	// Token: 0x02000086 RID: 134
	public enum KKFFKBLCPNB
	{
		// Token: 0x04000336 RID: 822
		Down,
		// Token: 0x04000337 RID: 823
		Up
	}

	// Token: 0x02000087 RID: 135
	public enum FQBMEEEJOGE
	{
		// Token: 0x04000339 RID: 825
		None,
		// Token: 0x0400033A RID: 826
		Alphabetic,
		// Token: 0x0400033B RID: 827
		Horizontal,
		// Token: 0x0400033C RID: 828
		Vertical,
		// Token: 0x0400033D RID: 829
		Custom
	}
}
