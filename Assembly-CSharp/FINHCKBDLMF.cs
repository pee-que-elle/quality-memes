using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using PSXAPI.Response;
using UnityEngine;

// Token: 0x02000244 RID: 580
public class FINHCKBDLMF : MonoBehaviour
{
	// Token: 0x06004F22 RID: 20258 RVA: 0x00020271 File Offset: 0x0001E471
	public void QBLBOMLDBQG(string IHIHHCCEDHQ)
	{
		if (this.IBQQGDJKEGL != IHIHHCCEDHQ)
		{
			this.IBQQGDJKEGL = IHIHHCCEDHQ;
			if (this.IBQQGDJKEGL == "telekinesis")
			{
				this.PPNEMMKQFBI();
			}
		}
	}

	// Token: 0x06004F23 RID: 20259 RVA: 0x00002300 File Offset: 0x00000500
	private void CMLGQHQJDGQ()
	{
	}

	// Token: 0x06004F24 RID: 20260 RVA: 0x0028E964 File Offset: 0x0028CB64
	public void BEJJKHKDLGK()
	{
		if (this.OIJININLENP.Count > 1)
		{
			foreach (FINHCKBDLMF.QJOLHBMONMH qjolhbmonmh in this.OIJININLENP)
			{
				if (qjolhbmonmh.BJGCBDNBQCJ.materials[1] != null)
				{
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[0].GetTexture("/force right") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureOffset("3_", qjolhbmonmh.JPGKPFKIGMH);
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureScale("[33ccff]Lv. ", qjolhbmonmh.FIBNMPJKIHF);
					}
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[1].GetTexture("FactoryTempTexture") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureOffset("replace", qjolhbmonmh.JBECBLJIKHI);
						qjolhbmonmh.BJGCBDNBQCJ.materials[1].SetTextureScale("[PG]", qjolhbmonmh.HQNNQKLEDCG);
					}
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[0].GetTexture("FOG_SUN_SHADOWS_ON") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[1].SetTextureOffset("Horizontal", qjolhbmonmh.HJNEBGEBKBN);
						qjolhbmonmh.BJGCBDNBQCJ.materials[1].SetTextureScale("-clearpositiveboost", qjolhbmonmh.DMLEPFPMKEK);
					}
				}
			}
		}
	}

	// Token: 0x06004F26 RID: 20262 RVA: 0x00002300 File Offset: 0x00000500
	private void GBGEGKHDQKB()
	{
	}

	// Token: 0x06004F27 RID: 20263 RVA: 0x0028EB08 File Offset: 0x0028CD08
	private IEnumerator HPODPEHPOKI(GameObject FIFNHCKNDQE)
	{
		yield return null;
		return 1;
		if (!(FIFNHCKNDQE != null) || FIFNHCKNDQE.GetComponentsInChildren<SkinnedMeshRenderer>() == null)
		{
			goto IL_B0;
		}
		SkinnedMeshRenderer[] componentsInChildren = FIFNHCKNDQE.GetComponentsInChildren<SkinnedMeshRenderer>();
		int num = 0;
		goto IL_A0;
		IL_6E:
		SkinnedMeshRenderer skinnedMeshRenderer = componentsInChildren[num];
		skinnedMeshRenderer.transform.parent = skinnedMeshRenderer.rootBone.transform;
		num++;
		IL_A0:
		if (num < componentsInChildren.Length)
		{
			goto IL_6E;
		}
		IL_B0:
		yield break;
	}

	// Token: 0x06004F28 RID: 20264 RVA: 0x000202AE File Offset: 0x0001E4AE
	public void DJFENJNJQNG(string IHIHHCCEDHQ)
	{
		if (this.IBQQGDJKEGL != IHIHHCCEDHQ)
		{
			this.IBQQGDJKEGL = IHIHHCCEDHQ;
			if (this.IBQQGDJKEGL == "0")
			{
				this.FMLQLGPFGKL();
			}
		}
	}

	// Token: 0x06004F29 RID: 20265 RVA: 0x00002300 File Offset: 0x00000500
	private void FOPKBNIOGCP()
	{
	}

	// Token: 0x06004F2A RID: 20266 RVA: 0x0028EB08 File Offset: 0x0028CD08
	private IEnumerator PJPFFBOPKKB(GameObject FIFNHCKNDQE)
	{
		yield return null;
		return 1;
		if (!(FIFNHCKNDQE != null) || FIFNHCKNDQE.GetComponentsInChildren<SkinnedMeshRenderer>() == null)
		{
			goto IL_B0;
		}
		componentsInChildren = FIFNHCKNDQE.GetComponentsInChildren<SkinnedMeshRenderer>();
		num = 0;
		goto IL_A0;
		IL_6E:
		SkinnedMeshRenderer skinnedMeshRenderer = componentsInChildren[num];
		skinnedMeshRenderer.transform.parent = skinnedMeshRenderer.rootBone.transform;
		num++;
		IL_A0:
		if (num < componentsInChildren.Length)
		{
			goto IL_6E;
		}
		IL_B0:
		yield break;
	}

	// Token: 0x06004F2B RID: 20267 RVA: 0x000202DD File Offset: 0x0001E4DD
	public void BBDEKLOBJDD(string IHIHHCCEDHQ)
	{
		if (this.IBQQGDJKEGL != IHIHHCCEDHQ)
		{
			this.IBQQGDJKEGL = IHIHHCCEDHQ;
			if (this.IBQQGDJKEGL == "[-]")
			{
				this.FMLQLGPFGKL();
			}
		}
	}

	// Token: 0x06004F2C RID: 20268 RVA: 0x0028EB24 File Offset: 0x0028CD24
	public void BQLIIQIIMDH(int IKIJBQLMKJO, bool DKFBPJOEGQC, Vector3 BDBBEMKFGPI, Vector3 EIGOEJLIGCG, string JJPDHJPLNGQ = null, string GFFQFOFDBGE = "M")
	{
		GFFQFOFDBGE = GFFQFOFDBGE.Replace("[", string.Empty);
		GFFQFOFDBGE = GFFQFOFDBGE.Replace("]", string.Empty);
		this.NGCLGFMBMHL = IKIJBQLMKJO;
		base.transform.NMBPDMIIHJB();
		base.transform.position = Vector3.zero;
		base.transform.localScale = Vector3.one;
		if (IKIJBQLMKJO == 9999)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(CNCJKLNHQBH.QOQONHOOLNE.HJBPDHBLOIQ, base.transform, false);
			if (JJPDHJPLNGQ != "Crack")
			{
				gameObject.transform.KQQJCMQCFMN("Crack").gameObject.SetActive(false);
			}
			base.transform.localScale = Vector3.one;
			gameObject.transform.localScale = Vector3.one;
			Bounds bounds = default(Bounds);
			foreach (SkinnedMeshRenderer skinnedMeshRenderer in gameObject.GetComponentsInChildren<SkinnedMeshRenderer>())
			{
				bounds.Encapsulate(skinnedMeshRenderer.bounds);
			}
			base.GetComponent<BoxCollider>().size = new Vector3(bounds.size.x / 4f * 3f, bounds.size.y, bounds.size.z / 2f);
			base.GetComponent<BoxCollider>().center = new Vector3(0f, bounds.size.y / 2f, 0f);
			base.transform.localEulerAngles = EIGOEJLIGCG;
			base.transform.localScale = Vector3.zero;
			base.transform.position = BDBBEMKFGPI;
			this.LCHODFNJNBH = 1f;
			if (this.LINELKKDMEE > 0)
			{
				base.transform.localScale = new Vector3(this.LCHODFNJNBH, this.LCHODFNJNBH, this.LCHODFNJNBH) * 0.014f;
				float num = Mathf.Max(new float[]
				{
					bounds.size.x,
					bounds.size.y,
					bounds.size.z
				}) * 1.5f * 0.01f;
				float num2 = bounds.size.y * this.LCHODFNJNBH * 0.01f;
				num /= 2f * Mathf.Tan(0.5235988f);
				base.transform.localPosition = Vector3.zero;
				num /= 2f * Mathf.Tan(0.5235988f);
				this.LNCKNGKGHLN.position = new Vector3(0f, num2 / 2f + num2 * 0.2f, -num * 2f);
			}
			if (this.LINELKKDMEE == 1)
			{
				gameObject.layer = 13;
				base.transform.ONDIKKGKGBN(13);
			}
			else if (this.LINELKKDMEE == 2)
			{
				gameObject.layer = 14;
				base.transform.ONDIKKGKGBN(14);
			}
			else if (this.LINELKKDMEE == 3)
			{
				gameObject.layer = 19;
				base.transform.ONDIKKGKGBN(19);
			}
			else
			{
				gameObject.layer = 9;
				base.transform.ONDIKKGKGBN(9);
			}
		}
		else
		{
			KGQECFKLKOP.ModelID modelID = KGQECFKLKOP.CEKEFONEMIK(IKIJBQLMKJO);
			this.QJJFOHNEOLQ = -1;
			float num3 = 1f;
			if (JJPDHJPLNGQ != null)
			{
				JJPDHJPLNGQ = KGQECFKLKOP.FMLPNPFKFLM(JJPDHJPLNGQ);
			}
			if (modelID != null && (JJPDHJPLNGQ == null || JJPDHJPLNGQ.Contains("mega") || JJPDHJPLNGQ.Contains("primal")))
			{
				num3 = modelID.ScaleFactor;
				if (JJPDHJPLNGQ != null && JJPDHJPLNGQ.Contains("megax"))
				{
					this.QJJFOHNEOLQ = modelID.MegaID;
					num3 = modelID.ScaleFactorMega;
				}
				else if (JJPDHJPLNGQ != null && JJPDHJPLNGQ.Contains("megay"))
				{
					this.QJJFOHNEOLQ = modelID.MegaYID;
					num3 = modelID.ScaleFactorMega;
				}
				else if (JJPDHJPLNGQ != null && JJPDHJPLNGQ.Contains("mega"))
				{
					this.QJJFOHNEOLQ = modelID.MegaID;
					num3 = modelID.ScaleFactorMega;
				}
				else if (JJPDHJPLNGQ != null && JJPDHJPLNGQ.Contains("primal"))
				{
					this.QJJFOHNEOLQ = modelID.PrimalID;
				}
				else if (IKIJBQLMKJO == 585)
				{
					if (CNCJKLNHQBH.QOQONHOOLNE.LKIBNLMIGKG == GameSeason.Spring)
					{
						this.QJJFOHNEOLQ = 817;
					}
					else if (CNCJKLNHQBH.QOQONHOOLNE.LKIBNLMIGKG == GameSeason.Summer)
					{
						this.QJJFOHNEOLQ = 818;
					}
					else if (CNCJKLNHQBH.QOQONHOOLNE.LKIBNLMIGKG == GameSeason.Autumn)
					{
						this.QJJFOHNEOLQ = 819;
					}
					else if (CNCJKLNHQBH.QOQONHOOLNE.LKIBNLMIGKG == GameSeason.Winter)
					{
						this.QJJFOHNEOLQ = 820;
					}
					else
					{
						this.QJJFOHNEOLQ = 817;
					}
				}
				else if (IKIJBQLMKJO == 586)
				{
					Debug.Log(CNCJKLNHQBH.QOQONHOOLNE.LKIBNLMIGKG);
					if (CNCJKLNHQBH.QOQONHOOLNE.LKIBNLMIGKG == GameSeason.Spring)
					{
						this.QJJFOHNEOLQ = 821;
					}
					else if (CNCJKLNHQBH.QOQONHOOLNE.LKIBNLMIGKG == GameSeason.Summer)
					{
						this.QJJFOHNEOLQ = 822;
					}
					else if (CNCJKLNHQBH.QOQONHOOLNE.LKIBNLMIGKG == GameSeason.Autumn)
					{
						this.QJJFOHNEOLQ = 823;
					}
					else if (CNCJKLNHQBH.QOQONHOOLNE.LKIBNLMIGKG == GameSeason.Winter)
					{
						this.QJJFOHNEOLQ = 824;
					}
					else
					{
						this.QJJFOHNEOLQ = 821;
					}
				}
				else if (GFFQFOFDBGE == "M")
				{
					this.QJJFOHNEOLQ = modelID.MaleID;
				}
				else if (GFFQFOFDBGE == "F")
				{
					this.QJJFOHNEOLQ = modelID.FemaleID;
				}
				else
				{
					this.QJJFOHNEOLQ = modelID.MaleID;
				}
			}
			if (this.QJJFOHNEOLQ == -1)
			{
				Debug.Log("No Mapping For Pokemon" + IKIJBQLMKJO.ToString() + " - " + JJPDHJPLNGQ);
				for (int j = 0; j < KGQECFKLKOP.GLFOCQDNHQC.Length; j++)
				{
					if (KGQECFKLKOP.GLFOCQDNHQC[j].Contains(KGQECFKLKOP.NNHFLHEQMOI(IKIJBQLMKJO)))
					{
						if (JJPDHJPLNGQ != null)
						{
							if (JJPDHJPLNGQ == "shayminsky" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Sky"))
							{
								this.QJJFOHNEOLQ = j;
								break;
							}
							if (JJPDHJPLNGQ == "shaymin" && !KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Sky"))
							{
								this.QJJFOHNEOLQ = j;
							}
							else
							{
								if (JJPDHJPLNGQ == "castform" && !KGQECFKLKOP.GLFOCQDNHQC[j].Contains("("))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "castformsnowy" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Snowy"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "castformsunny" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Sunny"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "castformrainy" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Rainy"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "burmysandy" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Sandy"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "burmytrash" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Trash"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "burmy" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Plant"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "wormadam" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Plant"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "cherrim" && !KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Sun"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "cherrimsunshine" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Sun"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "wormadamsandy" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Sandy"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "wormadamtrash" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Trash"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "darmanitanzen" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Zen"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "darmanitan" && !KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Zen"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "aegislashblade" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Blade"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "aegislash" && !KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Blade"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "aegislash" && !KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Blade"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "shellos" && !KGQECFKLKOP.GLFOCQDNHQC[j].Contains("East"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "shelloseast" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("East"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "gastrodon" && !KGQECFKLKOP.GLFOCQDNHQC[j].Contains("East"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "gastrodoneast" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("East"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "rotom" && !KGQECFKLKOP.GLFOCQDNHQC[j].Contains("("))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "rotomheat" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Heat"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "rotomwash" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Wash"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "rotomfrost" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Frost"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "rotomfan" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Fan"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "rotommow" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Mow"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "wishiwashischool" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("School"))
								{
									num3 = 0.8f;
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "mimikyubusted" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Busted"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "miniormeteor" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Meteor"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "miniorcore" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Core"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (JJPDHJPLNGQ == "minior" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Core"))
								{
									this.QJJFOHNEOLQ = j;
									break;
								}
								if (IKIJBQLMKJO == 201)
								{
									if (JJPDHJPLNGQ == "0" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(A)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "1" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(B)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "2" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(C)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "3" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(D)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "4" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(E)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "5" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(F)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "6" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(G)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "7" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(H)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "8" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(I)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "9" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(J)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "10" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(K)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "11" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(L)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "12" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(M)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "13" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(N)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "14" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(O)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "15" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(P)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "16" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(Q)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "17" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(R)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "18" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(S)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "19" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(T)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "20" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(U)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "21" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(V)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "22" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(W)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "23" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(X)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "24" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(Y)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "25" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(Z)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "26" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(Ex)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
									if (JJPDHJPLNGQ == "27" && KGQECFKLKOP.GLFOCQDNHQC[j].Contains("(Qu)"))
									{
										this.QJJFOHNEOLQ = j;
										break;
									}
								}
							}
						}
						else if (!KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Mega") && !KGQECFKLKOP.GLFOCQDNHQC[j].Contains("Female"))
						{
							this.QJJFOHNEOLQ = j;
							break;
						}
					}
				}
			}
			if (IKIJBQLMKJO != 0)
			{
				int num4 = 0;
				if (this.QJJFOHNEOLQ < 100)
				{
					num4 = 0;
				}
				else if (this.QJJFOHNEOLQ < 200)
				{
					num4 = 1;
				}
				else if (this.QJJFOHNEOLQ < 300)
				{
					num4 = 2;
				}
				else if (this.QJJFOHNEOLQ < 400)
				{
					num4 = 3;
				}
				else if (this.QJJFOHNEOLQ < 500)
				{
					num4 = 4;
				}
				else if (this.QJJFOHNEOLQ < 600)
				{
					num4 = 5;
				}
				else if (this.QJJFOHNEOLQ < 700)
				{
					num4 = 6;
				}
				else if (this.QJJFOHNEOLQ < 800)
				{
					num4 = 7;
				}
				else if (this.QJJFOHNEOLQ < 900)
				{
					num4 = 8;
				}
				else if (this.QJJFOHNEOLQ < 1023)
				{
					num4 = 9;
				}
				else if (this.QJJFOHNEOLQ < 1200)
				{
					num4 = 10;
				}
				if (FINHCKBDLMF.BMIMGKLBEJF[num4] == null)
				{
					FINHCKBDLMF.BMIMGKLBEJF[num4] = AssetBundle.LoadFromFile(System.IO.Path.Combine(Application.streamingAssetsPath, "pdata" + (num4 + 1).ToString()));
				}
				GameObject gameObject;
				if (DKFBPJOEGQC && (this.QJJFOHNEOLQ == 115 || this.QJJFOHNEOLQ == 116 || this.QJJFOHNEOLQ == 267))
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(FINHCKBDLMF.BMIMGKLBEJF[num4].LoadAsset<GameObject>(string.Concat(new string[]
					{
						"Assets/AssetBundles/Pokes",
						(num4 + 1).ToString(),
						"/",
						this.QJJFOHNEOLQ.ToString(),
						"/Model_S.prefab"
					})), base.transform, false);
				}
				else
				{
					gameObject = UnityEngine.Object.Instantiate<GameObject>(FINHCKBDLMF.BMIMGKLBEJF[num4].LoadAsset<GameObject>(string.Concat(new string[]
					{
						"Assets/AssetBundles/Pokes",
						(num4 + 1).ToString(),
						"/",
						this.QJJFOHNEOLQ.ToString(),
						"/Model.prefab"
					})), base.transform, false);
				}
				if (gameObject == null)
				{
					return;
				}
				gameObject.transform.parent = base.transform;
				gameObject.transform.localPosition = Vector3.zero;
				gameObject.transform.localEulerAngles = Vector3.zero;
				gameObject.transform.localScale = Vector3.one;
				if (this.LINELKKDMEE == 1)
				{
					gameObject.layer = 13;
					base.transform.ONDIKKGKGBN(13);
				}
				else if (this.LINELKKDMEE == 2)
				{
					gameObject.layer = 14;
					base.transform.ONDIKKGKGBN(14);
				}
				else if (this.LINELKKDMEE == 3)
				{
					gameObject.layer = 19;
					base.transform.ONDIKKGKGBN(19);
				}
				else
				{
					gameObject.layer = 9;
					base.transform.ONDIKKGKGBN(9);
				}
				this.GJLIKEBKPBD = gameObject.GetComponent<Animation>();
				if (this.GJLIKEBKPBD.GetClip("0") != null)
				{
					this.GJLIKEBKPBD.GetClip("0").SampleAnimation(gameObject, 0f);
				}
				base.transform.localScale = Vector3.one;
				gameObject.transform.localScale = Vector3.one;
				Bounds bounds2 = default(Bounds);
				this.OIJININLENP.Clear();
				foreach (SkinnedMeshRenderer skinnedMeshRenderer2 in gameObject.GetComponentsInChildren<SkinnedMeshRenderer>())
				{
					bounds2.Encapsulate(skinnedMeshRenderer2.bounds);
					if (DKFBPJOEGQC)
					{
						if (FINHCKBDLMF.BMIMGKLBEJF[num4] == null)
						{
							FINHCKBDLMF.BMIMGKLBEJF[num4] = AssetBundle.LoadFromFile(System.IO.Path.Combine(Application.streamingAssetsPath, "pdata" + (num4 + 1).ToString()));
						}
						if (skinnedMeshRenderer2.materials[0] != null && skinnedMeshRenderer2.materials[0].GetTexture("_Texture0") != null)
						{
							skinnedMeshRenderer2.materials[0].SetTexture("_Texture0", FINHCKBDLMF.BMIMGKLBEJF[num4].LoadAsset<Texture2D>(string.Concat(new string[]
							{
								"Assets/AssetBundles/Pokes",
								(num4 + 1).ToString(),
								"/",
								this.QJJFOHNEOLQ.ToString(),
								"/Shiny/",
								skinnedMeshRenderer2.materials[0].GetTexture("_Texture0").name,
								".png"
							})));
						}
					}
					if (skinnedMeshRenderer2.materials[0] != null)
					{
						FINHCKBDLMF.QJOLHBMONMH item = default(FINHCKBDLMF.QJOLHBMONMH);
						item.BJGCBDNBQCJ = skinnedMeshRenderer2;
						if (skinnedMeshRenderer2.materials[0].GetTexture("_Texture0") != null)
						{
							item.JPGKPFKIGMH = skinnedMeshRenderer2.materials[0].GetTextureOffset("_Texture0");
							item.FIBNMPJKIHF = skinnedMeshRenderer2.materials[0].GetTextureScale("_Texture0");
						}
						if (skinnedMeshRenderer2.materials[0].GetTexture("_Texture1") != null)
						{
							item.JBECBLJIKHI = skinnedMeshRenderer2.materials[0].GetTextureOffset("_Texture1");
							item.HQNNQKLEDCG = skinnedMeshRenderer2.materials[0].GetTextureScale("_Texture1");
						}
						if (skinnedMeshRenderer2.materials[0].GetTexture("_Texture2") != null)
						{
							item.HJNEBGEBKBN = skinnedMeshRenderer2.materials[0].GetTextureOffset("_Texture2");
							item.DMLEPFPMKEK = skinnedMeshRenderer2.materials[0].GetTextureScale("_Texture2");
						}
						this.OIJININLENP.Add(item);
					}
				}
				base.GetComponent<BoxCollider>().size = new Vector3(bounds2.size.x / 4f * 3f, bounds2.size.y, bounds2.size.z / 2f);
				base.GetComponent<BoxCollider>().center = new Vector3(0f, bounds2.size.y / 2f, 0f);
				base.transform.localEulerAngles = EIGOEJLIGCG;
				base.transform.localScale = Vector3.zero;
				base.transform.position = BDBBEMKFGPI;
				this.LCHODFNJNBH = this.IMKDJPBJMFJ / Mathf.Lerp(this.IMKDJPBJMFJ, bounds2.size.y, this.FGKHPQJKPHD);
				this.LCHODFNJNBH *= num3;
				if (this.LINELKKDMEE > 0)
				{
					base.transform.localScale = new Vector3(this.LCHODFNJNBH, this.LCHODFNJNBH, this.LCHODFNJNBH) * 0.014f;
					float num5 = Mathf.Max(new float[]
					{
						bounds2.size.x,
						bounds2.size.y,
						bounds2.size.z
					}) * this.LCHODFNJNBH * 0.01f;
					float num6 = bounds2.size.y * this.LCHODFNJNBH * 0.01f;
					num5 /= 2f * Mathf.Tan(0.5235988f);
					base.transform.localPosition = Vector3.zero;
					this.LNCKNGKGHLN.position = new Vector3(0f, num6 / 2f + num6 * 0.2f, -num5 * 2f);
					if (IKIJBQLMKJO == 201)
					{
						base.transform.localScale = new Vector3(-this.LCHODFNJNBH, this.LCHODFNJNBH, this.LCHODFNJNBH) * 0.01f;
					}
				}
				IEnumerator enumerator = this.GJLIKEBKPBD.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						AnimationState animationState = (AnimationState)obj;
						AnimationEvent animationEvent = new AnimationEvent();
						animationEvent.stringParameter = animationState.name;
						animationEvent.functionName = "SetCurrentPlayingAnimation";
						animationEvent.time = 0f;
						this.GJLIKEBKPBD[animationState.name].clip.AddEvent(animationEvent);
					}
				}
				finally
				{
					IDisposable disposable;
					if ((disposable = (enumerator as IDisposable)) != null)
					{
						disposable.Dispose();
					}
				}
				FGJGBIFFGCP fgjgbiffgcp = this.GJLIKEBKPBD.gameObject.AddComponent<FGJGBIFFGCP>();
				fgjgbiffgcp.QEPKKJKQMPP = this;
				if (this.GJLIKEBKPBD.GetClip("0") != null)
				{
					this.GJLIKEBKPBD.Play("0");
				}
				base.StartCoroutine(this.PJPFFBOPKKB(gameObject));
			}
			else
			{
				base.transform.localEulerAngles = EIGOEJLIGCG;
				base.transform.localScale = Vector3.zero;
				base.transform.position = BDBBEMKFGPI;
			}
		}
	}

	// Token: 0x06004F2D RID: 20269 RVA: 0x0002030C File Offset: 0x0001E50C
	public void EIGPIFQDJNI(string IHIHHCCEDHQ)
	{
		if (this.IBQQGDJKEGL != IHIHHCCEDHQ)
		{
			this.IBQQGDJKEGL = IHIHHCCEDHQ;
			if (this.IBQQGDJKEGL == "HidePanel")
			{
				this.PPNEMMKQFBI();
			}
		}
	}

	// Token: 0x06004F2E RID: 20270 RVA: 0x00290660 File Offset: 0x0028E860
	public void DQOFLQQBMQO()
	{
		if (this.OIJININLENP.Count > 0)
		{
			foreach (FINHCKBDLMF.QJOLHBMONMH qjolhbmonmh in this.OIJININLENP)
			{
				if (qjolhbmonmh.BJGCBDNBQCJ.materials[0] != null)
				{
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[0].GetTexture("DontScale") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[1].SetTextureOffset("[CFX_SpawnSystem.GetNextObject()] There are no active instances available in the pool for \"", qjolhbmonmh.JPGKPFKIGMH);
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureScale("Prevents status conditions in sunny weather.", qjolhbmonmh.FIBNMPJKIHF);
					}
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[1].GetTexture(" is tormented!\r\n") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureOffset("Aargh! Almost had it!\r\n", qjolhbmonmh.JBECBLJIKHI);
						qjolhbmonmh.BJGCBDNBQCJ.materials[1].SetTextureScale("AlwaysRain", qjolhbmonmh.HQNNQKLEDCG);
					}
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[1].GetTexture("#") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[1].SetTextureOffset(" is hurt by the sea of fire!\r\n", qjolhbmonmh.HJNEBGEBKBN);
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureScale("grasspelt", qjolhbmonmh.DMLEPFPMKEK);
					}
				}
			}
		}
	}

	// Token: 0x06004F2F RID: 20271 RVA: 0x00290804 File Offset: 0x0028EA04
	public void MNGJJMMCIQF()
	{
		if (this.OIJININLENP.Count > 1)
		{
			foreach (FINHCKBDLMF.QJOLHBMONMH qjolhbmonmh in this.OIJININLENP)
			{
				if (qjolhbmonmh.BJGCBDNBQCJ.materials[0] != null)
				{
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[0].GetTexture("'s attack missed!\r\n") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureOffset("No Animation found for MoveID ", qjolhbmonmh.JPGKPFKIGMH);
						qjolhbmonmh.BJGCBDNBQCJ.materials[1].SetTextureScale("#,##0", qjolhbmonmh.FIBNMPJKIHF);
					}
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[1].GetTexture("F4") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureOffset("14", qjolhbmonmh.JBECBLJIKHI);
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureScale("Player/Body", qjolhbmonmh.HQNNQKLEDCG);
					}
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[1].GetTexture("Ditto") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureOffset("It reduced the PP of ", qjolhbmonmh.HJNEBGEBKBN);
						qjolhbmonmh.BJGCBDNBQCJ.materials[1].SetTextureScale("_FogVoidPosition", qjolhbmonmh.DMLEPFPMKEK);
					}
				}
			}
		}
	}

	// Token: 0x06004F30 RID: 20272 RVA: 0x002909A8 File Offset: 0x0028EBA8
	public void PPNEMMKQFBI()
	{
		if (this.OIJININLENP.Count > 0)
		{
			foreach (FINHCKBDLMF.QJOLHBMONMH qjolhbmonmh in this.OIJININLENP)
			{
				if (qjolhbmonmh.BJGCBDNBQCJ.materials[0] != null)
				{
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[0].GetTexture("System") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureOffset("Battle Update: ", qjolhbmonmh.JPGKPFKIGMH);
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureScale("aftermath", qjolhbmonmh.FIBNMPJKIHF);
					}
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[0].GetTexture("[FF8787]Lv") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[1].SetTextureOffset("Drought", qjolhbmonmh.JBECBLJIKHI);
						qjolhbmonmh.BJGCBDNBQCJ.materials[1].SetTextureScale("map:", qjolhbmonmh.HQNNQKLEDCG);
					}
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[1].GetTexture(" restored PP to its [ffff00]") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[1].SetTextureOffset("music(", qjolhbmonmh.HJNEBGEBKBN);
						qjolhbmonmh.BJGCBDNBQCJ.materials[1].SetTextureScale("Battle Update: ", qjolhbmonmh.DMLEPFPMKEK);
					}
				}
			}
		}
	}

	// Token: 0x06004F31 RID: 20273 RVA: 0x00290B4C File Offset: 0x0028ED4C
	public void NNOEMPNKFHJ()
	{
		if (this.OIJININLENP.Count > 1)
		{
			foreach (FINHCKBDLMF.QJOLHBMONMH qjolhbmonmh in this.OIJININLENP)
			{
				if (qjolhbmonmh.BJGCBDNBQCJ.materials[1] != null)
				{
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[1].GetTexture("Windowed") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[1].SetTextureOffset("skydop", qjolhbmonmh.JPGKPFKIGMH);
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureScale("Illuminate", qjolhbmonmh.FIBNMPJKIHF);
					}
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[0].GetTexture("BuffIcon_SandstormEncounterDecreased") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureOffset("_Smoothing", qjolhbmonmh.JBECBLJIKHI);
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureScale(" hours ago", qjolhbmonmh.HQNNQKLEDCG);
					}
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[1].GetTexture("Are you sure you wish to confirm your EV changes on [2ecc71]") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[1].SetTextureOffset("'s [ffff00]", qjolhbmonmh.HJNEBGEBKBN);
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureScale("_MainTex", qjolhbmonmh.DMLEPFPMKEK);
					}
				}
			}
		}
	}

	// Token: 0x06004F32 RID: 20274 RVA: 0x00002300 File Offset: 0x00000500
	private void QBGOGFJCLEP()
	{
	}

	// Token: 0x06004F33 RID: 20275 RVA: 0x0002033B File Offset: 0x0001E53B
	public void QQGNMCBNGEI(string IHIHHCCEDHQ)
	{
		if (this.IBQQGDJKEGL != IHIHHCCEDHQ)
		{
			this.IBQQGDJKEGL = IHIHHCCEDHQ;
			if (this.IBQQGDJKEGL == " was kicked from the Party.")
			{
				this.MNGJJMMCIQF();
			}
		}
	}

	// Token: 0x06004F34 RID: 20276 RVA: 0x00002300 File Offset: 0x00000500
	private void Start()
	{
	}

	// Token: 0x06004F35 RID: 20277 RVA: 0x00290CF0 File Offset: 0x0028EEF0
	public void FMLQLGPFGKL()
	{
		if (this.OIJININLENP.Count > 0)
		{
			foreach (FINHCKBDLMF.QJOLHBMONMH qjolhbmonmh in this.OIJININLENP)
			{
				if (qjolhbmonmh.BJGCBDNBQCJ.materials[0] != null)
				{
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[0].GetTexture("_Texture0") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureOffset("_Texture0", qjolhbmonmh.JPGKPFKIGMH);
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureScale("_Texture0", qjolhbmonmh.FIBNMPJKIHF);
					}
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[0].GetTexture("_Texture1") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureOffset("_Texture1", qjolhbmonmh.JBECBLJIKHI);
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureScale("_Texture1", qjolhbmonmh.HQNNQKLEDCG);
					}
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[0].GetTexture("_Texture2") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureOffset("_Texture2", qjolhbmonmh.HJNEBGEBKBN);
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureScale("_Texture2", qjolhbmonmh.DMLEPFPMKEK);
					}
				}
			}
		}
	}

	// Token: 0x06004F37 RID: 20279 RVA: 0x0028EB08 File Offset: 0x0028CD08
	private IEnumerator MQDCPFPCBIE(GameObject FIFNHCKNDQE)
	{
		yield return null;
		return 1;
		if (!(FIFNHCKNDQE != null) || FIFNHCKNDQE.GetComponentsInChildren<SkinnedMeshRenderer>() == null)
		{
			goto IL_B0;
		}
		componentsInChildren = FIFNHCKNDQE.GetComponentsInChildren<SkinnedMeshRenderer>();
		num = 0;
		goto IL_A0;
		IL_6E:
		SkinnedMeshRenderer skinnedMeshRenderer = componentsInChildren[num];
		skinnedMeshRenderer.transform.parent = skinnedMeshRenderer.rootBone.transform;
		num++;
		IL_A0:
		if (num < componentsInChildren.Length)
		{
			goto IL_6E;
		}
		IL_B0:
		yield break;
	}

	// Token: 0x06004F38 RID: 20280 RVA: 0x00290E94 File Offset: 0x0028F094
	public void QNOQFKLQBNP()
	{
		if (this.OIJININLENP.Count > 1)
		{
			foreach (FINHCKBDLMF.QJOLHBMONMH qjolhbmonmh in this.OIJININLENP)
			{
				if (qjolhbmonmh.BJGCBDNBQCJ.materials[1] != null)
				{
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[1].GetTexture("move: ") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[1].SetTextureOffset("HidePanel", qjolhbmonmh.JPGKPFKIGMH);
						qjolhbmonmh.BJGCBDNBQCJ.materials[1].SetTextureScale("mega", qjolhbmonmh.FIBNMPJKIHF);
					}
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[0].GetTexture("The two moves have become one! It's a combined move!\r\n") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureOffset("The hail stopped.", qjolhbmonmh.JBECBLJIKHI);
						qjolhbmonmh.BJGCBDNBQCJ.materials[1].SetTextureScale("'s ", qjolhbmonmh.HQNNQKLEDCG);
					}
					if (qjolhbmonmh.BJGCBDNBQCJ.materials[0].GetTexture("flamewheel") != null)
					{
						qjolhbmonmh.BJGCBDNBQCJ.materials[1].SetTextureOffset("//", qjolhbmonmh.HJNEBGEBKBN);
						qjolhbmonmh.BJGCBDNBQCJ.materials[0].SetTextureScale("Clr", qjolhbmonmh.DMLEPFPMKEK);
					}
				}
			}
		}
	}

	// Token: 0x040010E9 RID: 4329
	private float IMKDJPBJMFJ = 300f;

	// Token: 0x040010EA RID: 4330
	public float LCHODFNJNBH;

	// Token: 0x040010EB RID: 4331
	[Range(0f, 1f)]
	public float FGKHPQJKPHD = 0.7f;

	// Token: 0x040010EC RID: 4332
	public int LINELKKDMEE;

	// Token: 0x040010ED RID: 4333
	public Transform LNCKNGKGHLN;

	// Token: 0x040010EE RID: 4334
	private Animation GJLIKEBKPBD;

	// Token: 0x040010EF RID: 4335
	private string IBQQGDJKEGL = "0";

	// Token: 0x040010F0 RID: 4336
	private int QJJFOHNEOLQ;

	// Token: 0x040010F1 RID: 4337
	public int NGCLGFMBMHL = 1;

	// Token: 0x040010F2 RID: 4338
	private List<FINHCKBDLMF.QJOLHBMONMH> OIJININLENP = new List<FINHCKBDLMF.QJOLHBMONMH>();

	// Token: 0x040010F3 RID: 4339
	private static AssetBundle[] BMIMGKLBEJF = new AssetBundle[11];

	// Token: 0x02000245 RID: 581
	public struct QJOLHBMONMH
	{
		// Token: 0x040010F4 RID: 4340
		public SkinnedMeshRenderer BJGCBDNBQCJ;

		// Token: 0x040010F5 RID: 4341
		public Vector2 JPGKPFKIGMH;

		// Token: 0x040010F6 RID: 4342
		public Vector2 FIBNMPJKIHF;

		// Token: 0x040010F7 RID: 4343
		public Vector2 JBECBLJIKHI;

		// Token: 0x040010F8 RID: 4344
		public Vector2 HQNNQKLEDCG;

		// Token: 0x040010F9 RID: 4345
		public Vector2 HJNEBGEBKBN;

		// Token: 0x040010FA RID: 4346
		public Vector2 DMLEPFPMKEK;
	}
}
