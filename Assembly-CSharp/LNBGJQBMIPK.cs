using System;
using UnityEngine;

// Token: 0x020001D3 RID: 467
public class LNBGJQBMIPK : MonoBehaviour
{
	// Token: 0x06003C43 RID: 15427 RVA: 0x001C8370 File Offset: 0x001C6570
	private void OnClick()
	{
		base.gameObject.transform.NMBPDMIIHJB();
		OQNEQCIKBQJ.QOQONHOOLNE.QGQDJIENFON();
		GGGPJQEKNJD.Hide();
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			if (!OGJJKKQPNMK.QOQONHOOLNE.POQOIMFLCHJ)
			{
				return;
			}
			Ray ray = this.HLFDQLEHQNI.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, float.PositiveInfinity, this.QMOMPLCPFMH) && raycastHit.collider != null && raycastHit.collider.gameObject && raycastHit.collider.gameObject.tag == "BattlePoke")
			{
				OGJJKKQPNMK.QOQONHOOLNE.IEBDBIOKOLC(raycastHit.collider.gameObject);
			}
		}
		if (!GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == -2)
		{
			Ray ray2 = this.PGHJQNJLJKG.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit2;
			if (Physics.Raycast(ray2, out raycastHit2, float.PositiveInfinity, this.LNEIBGCOBGE) && raycastHit2.collider != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>() != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>().IEFBCKQJBGN == null)
			{
				KGQECFKLKOP.LGHLQDLBBIB(raycastHit2.collider.gameObject.GetComponent<JFIBMMBLFDO>().MBPHKDQMJJH);
			}
		}
		if (GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == -1)
		{
			Ray ray3 = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>().ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit3;
			if (Physics.Raycast(ray3, out raycastHit3, float.PositiveInfinity, this.LNEIBGCOBGE) && raycastHit3.collider != null && raycastHit3.collider.gameObject.name == "Mouse Click Collider")
			{
				string djinhgfkccg = raycastHit3.collider.transform.parent.GetComponent<QDLMGFQHBJQ>().DJINHGFKCCG;
				KGQECFKLKOP.LGHLQDLBBIB(djinhgfkccg);
			}
		}
	}

	// Token: 0x06003C44 RID: 15428 RVA: 0x001C85A0 File Offset: 0x001C67A0
	private void CJIFEQFKPIM()
	{
		base.gameObject.transform.NMBPDMIIHJB();
		OQNEQCIKBQJ.QOQONHOOLNE.FFCEMKIQQFQ();
		GGGPJQEKNJD.Hide();
		if (OGJJKKQPNMK.CDDIILFBFCF() != null)
		{
			if (!OGJJKKQPNMK.QOQONHOOLNE.POQOIMFLCHJ)
			{
				return;
			}
			Ray ray = this.HLFDQLEHQNI.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 1707f, this.QMOMPLCPFMH) && raycastHit.collider != null && raycastHit.collider.gameObject && raycastHit.collider.gameObject.tag == "Leaf Guard")
			{
				OGJJKKQPNMK.CDDIILFBFCF().IEBDBIOKOLC(raycastHit.collider.gameObject);
			}
		}
		if (!GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == -53)
		{
			Ray ray2 = this.PGHJQNJLJKG.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit2;
			if (Physics.Raycast(ray2, out raycastHit2, 1885f, this.LNEIBGCOBGE) && raycastHit2.collider != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>() != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>().IEFBCKQJBGN == null)
			{
				KGQECFKLKOP.LGHLQDLBBIB(raycastHit2.collider.gameObject.GetComponent<JFIBMMBLFDO>().MBPHKDQMJJH);
			}
		}
		if (GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == -1)
		{
			Ray ray3 = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>().ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit3;
			if (Physics.Raycast(ray3, out raycastHit3, 140f, this.LNEIBGCOBGE) && raycastHit3.collider != null && raycastHit3.collider.gameObject.name == "LateUpdate")
			{
				string djinhgfkccg = raycastHit3.collider.transform.parent.GetComponent<QDLMGFQHBJQ>().DJINHGFKCCG;
				KGQECFKLKOP.LGHLQDLBBIB(djinhgfkccg);
			}
		}
	}

	// Token: 0x06003C45 RID: 15429 RVA: 0x00019451 File Offset: 0x00017651
	private void GCCGPFLIEBH(Vector2 JDOGIQGGLKM)
	{
		CNCJKLNHQBH.QOQONHOOLNE.OPMMEOJEBME = EMENMKHBPQE.JHEDGGMDIEE.ILOHLNLIKDF;
	}

	// Token: 0x06003C46 RID: 15430 RVA: 0x00019467 File Offset: 0x00017667
	private void DGMPMICDCIO()
	{
		EMENMKHBPQE.NBBKPCKOEPI = base.gameObject;
	}

	// Token: 0x06003C47 RID: 15431 RVA: 0x00019474 File Offset: 0x00017674
	private void BIGDQLEFKEL(float JDOGIQGGLKM)
	{
		CNCJKLNHQBH.MOGQNGEPCEO().LKHOCPNQIMB = JDOGIQGGLKM;
	}

	// Token: 0x06003C48 RID: 15432 RVA: 0x00019481 File Offset: 0x00017681
	private void HIFCDJQPMBP(Vector2 JDOGIQGGLKM)
	{
		CNCJKLNHQBH.BJLGEDCPENQ().OPMMEOJEBME = EMENMKHBPQE.JHEDGGMDIEE.ILOHLNLIKDF;
	}

	// Token: 0x06003C49 RID: 15433 RVA: 0x00019451 File Offset: 0x00017651
	private void DBCQJKNGJML(Vector2 JDOGIQGGLKM)
	{
		CNCJKLNHQBH.QOQONHOOLNE.OPMMEOJEBME = EMENMKHBPQE.JHEDGGMDIEE.ILOHLNLIKDF;
	}

	// Token: 0x06003C4A RID: 15434 RVA: 0x00019497 File Offset: 0x00017697
	private void PQNKOHBGFOP(bool IEMBKPKMCGQ)
	{
		if (!IEMBKPKMCGQ)
		{
			CNCJKLNHQBH.QOQONHOOLNE.OPMMEOJEBME = Vector2.zero;
		}
	}

	// Token: 0x06003C4B RID: 15435 RVA: 0x00019451 File Offset: 0x00017651
	private void OnDrag(Vector2 JDOGIQGGLKM)
	{
		CNCJKLNHQBH.QOQONHOOLNE.OPMMEOJEBME = EMENMKHBPQE.JHEDGGMDIEE.ILOHLNLIKDF;
	}

	// Token: 0x06003C4C RID: 15436 RVA: 0x000194AB File Offset: 0x000176AB
	private void IFCHONCBMGM(bool IEMBKPKMCGQ)
	{
		if (!IEMBKPKMCGQ)
		{
			CNCJKLNHQBH.BJLGEDCPENQ().OPMMEOJEBME = Vector2.zero;
		}
	}

	// Token: 0x06003C4D RID: 15437 RVA: 0x001C87D0 File Offset: 0x001C69D0
	private void FixedUpdate()
	{
		if (this.BIIFJOEKNOM && OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			if (!OGJJKKQPNMK.QOQONHOOLNE.POQOIMFLCHJ)
			{
				return;
			}
			Ray ray = this.HLFDQLEHQNI.ScreenPointToRay(Input.mousePosition);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, float.PositiveInfinity, this.QMOMPLCPFMH))
			{
				if (raycastHit.collider != null)
				{
					if (raycastHit.collider.gameObject && raycastHit.collider.gameObject.tag == "BattlePoke")
					{
						OGJJKKQPNMK.QOQONHOOLNE.LFKFEIJFIHC(raycastHit.collider.gameObject);
					}
					else
					{
						OGJJKKQPNMK.QOQONHOOLNE.LFKFEIJFIHC(null);
					}
				}
			}
			else
			{
				OGJJKKQPNMK.QOQONHOOLNE.LFKFEIJFIHC(null);
			}
		}
	}

	// Token: 0x06003C4E RID: 15438 RVA: 0x00019467 File Offset: 0x00017667
	private void DFNFEDMJKGK()
	{
		EMENMKHBPQE.NBBKPCKOEPI = base.gameObject;
	}

	// Token: 0x06003C4F RID: 15439 RVA: 0x00019497 File Offset: 0x00017697
	private void HGMEOIGFNKB(bool IEMBKPKMCGQ)
	{
		if (!IEMBKPKMCGQ)
		{
			CNCJKLNHQBH.QOQONHOOLNE.OPMMEOJEBME = Vector2.zero;
		}
	}

	// Token: 0x06003C50 RID: 15440 RVA: 0x001C88A0 File Offset: 0x001C6AA0
	private void DNLLCMHCHMJ()
	{
		base.gameObject.transform.NMBPDMIIHJB();
		OQNEQCIKBQJ.QOQONHOOLNE.FFCEMKIQQFQ();
		GGGPJQEKNJD.Hide();
		if (OGJJKKQPNMK.GGBPGMMCGLI() != null)
		{
			if (!OGJJKKQPNMK.QOQONHOOLNE.POQOIMFLCHJ)
			{
				return;
			}
			Ray ray = this.HLFDQLEHQNI.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 651f, this.QMOMPLCPFMH) && raycastHit.collider != null && raycastHit.collider.gameObject && raycastHit.collider.gameObject.tag == "2D")
			{
				OGJJKKQPNMK.CDDIILFBFCF().QCNFGQHGJDF(raycastHit.collider.gameObject);
			}
		}
		if (!GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == -101)
		{
			Ray ray2 = this.PGHJQNJLJKG.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit2;
			if (Physics.Raycast(ray2, out raycastHit2, 612f, this.LNEIBGCOBGE) && raycastHit2.collider != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>() != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>().IEFBCKQJBGN == null)
			{
				KGQECFKLKOP.LGHLQDLBBIB(raycastHit2.collider.gameObject.GetComponent<JFIBMMBLFDO>().MBPHKDQMJJH);
			}
		}
		if (GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == -1)
		{
			Ray ray3 = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>().ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit3;
			if (Physics.Raycast(ray3, out raycastHit3, 357f, this.LNEIBGCOBGE) && raycastHit3.collider != null && raycastHit3.collider.gameObject.name == "BuffIcon_Repel")
			{
				string djinhgfkccg = raycastHit3.collider.transform.parent.GetComponent<QDLMGFQHBJQ>().DJINHGFKCCG;
				KGQECFKLKOP.LGHLQDLBBIB(djinhgfkccg);
			}
		}
	}

	// Token: 0x06003C51 RID: 15441 RVA: 0x000194AB File Offset: 0x000176AB
	private void DKKQFEPDLHB(bool IEMBKPKMCGQ)
	{
		if (!IEMBKPKMCGQ)
		{
			CNCJKLNHQBH.BJLGEDCPENQ().OPMMEOJEBME = Vector2.zero;
		}
	}

	// Token: 0x06003C52 RID: 15442 RVA: 0x001C8AD0 File Offset: 0x001C6CD0
	private void GGMINIPOKJI()
	{
		base.gameObject.transform.NMBPDMIIHJB();
		OQNEQCIKBQJ.CPIJOBOQLOK().QGQDJIENFON();
		GGGPJQEKNJD.FDDBHCGOJLP();
		if (OGJJKKQPNMK.GGBPGMMCGLI() != null)
		{
			if (!OGJJKKQPNMK.GGBPGMMCGLI().POQOIMFLCHJ)
			{
				return;
			}
			Ray ray = this.HLFDQLEHQNI.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 242f, this.QMOMPLCPFMH) && raycastHit.collider != null && raycastHit.collider.gameObject && raycastHit.collider.gameObject.tag == "Orleans.Runtime.GatewayTooBusyException")
			{
				OGJJKKQPNMK.GGBPGMMCGLI().IEBDBIOKOLC(raycastHit.collider.gameObject);
			}
		}
		if (!GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == 84)
		{
			Ray ray2 = this.PGHJQNJLJKG.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit2;
			if (Physics.Raycast(ray2, out raycastHit2, 912f, this.LNEIBGCOBGE) && raycastHit2.collider != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>() != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>().IEFBCKQJBGN == null)
			{
				KGQECFKLKOP.LGHLQDLBBIB(raycastHit2.collider.gameObject.GetComponent<JFIBMMBLFDO>().MBPHKDQMJJH);
			}
		}
		if (GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == -1)
		{
			Ray ray3 = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>().ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit3;
			if (Physics.Raycast(ray3, out raycastHit3, 1874f, this.LNEIBGCOBGE) && raycastHit3.collider != null && raycastHit3.collider.gameObject.name == " on ")
			{
				string djinhgfkccg = raycastHit3.collider.transform.parent.GetComponent<QDLMGFQHBJQ>().DJINHGFKCCG;
				KGQECFKLKOP.LGHLQDLBBIB(djinhgfkccg);
			}
		}
	}

	// Token: 0x06003C53 RID: 15443 RVA: 0x000194BF File Offset: 0x000176BF
	private void BNBEHQEHDKL(bool IFFGDNBQHLO)
	{
		this.BIIFJOEKNOM = IFFGDNBQHLO;
	}

	// Token: 0x06003C54 RID: 15444 RVA: 0x001C8D00 File Offset: 0x001C6F00
	private void MLJHFBQHCCL()
	{
		base.gameObject.transform.NMBPDMIIHJB();
		OQNEQCIKBQJ.QOQONHOOLNE.FFCEMKIQQFQ();
		GGGPJQEKNJD.Hide();
		if (OGJJKKQPNMK.GGBPGMMCGLI() != null)
		{
			if (!OGJJKKQPNMK.CDDIILFBFCF().POQOIMFLCHJ)
			{
				return;
			}
			Ray ray = this.HLFDQLEHQNI.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 900f, this.QMOMPLCPFMH) && raycastHit.collider != null && raycastHit.collider.gameObject && raycastHit.collider.gameObject.tag == "analytic")
			{
				OGJJKKQPNMK.GGBPGMMCGLI().QCNFGQHGJDF(raycastHit.collider.gameObject);
			}
		}
		if (!GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == -2)
		{
			Ray ray2 = this.PGHJQNJLJKG.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit2;
			if (Physics.Raycast(ray2, out raycastHit2, 558f, this.LNEIBGCOBGE) && raycastHit2.collider != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>() != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>().IEFBCKQJBGN == null)
			{
				KGQECFKLKOP.LGHLQDLBBIB(raycastHit2.collider.gameObject.GetComponent<JFIBMMBLFDO>().MBPHKDQMJJH);
			}
		}
		if (GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == -1)
		{
			Ray ray3 = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>().ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit3;
			if (Physics.Raycast(ray3, out raycastHit3, 1469f, this.LNEIBGCOBGE) && raycastHit3.collider != null && raycastHit3.collider.gameObject.name == "Slots_4")
			{
				string djinhgfkccg = raycastHit3.collider.transform.parent.GetComponent<QDLMGFQHBJQ>().DJINHGFKCCG;
				KGQECFKLKOP.LGHLQDLBBIB(djinhgfkccg);
			}
		}
	}

	// Token: 0x06003C55 RID: 15445 RVA: 0x000194BF File Offset: 0x000176BF
	private void LJMOLEKDCLP(bool IFFGDNBQHLO)
	{
		this.BIIFJOEKNOM = IFFGDNBQHLO;
	}

	// Token: 0x06003C56 RID: 15446 RVA: 0x000194C8 File Offset: 0x000176C8
	private void HPDPPFLLKFL(Vector2 JDOGIQGGLKM)
	{
		CNCJKLNHQBH.MOGQNGEPCEO().OPMMEOJEBME = EMENMKHBPQE.JHEDGGMDIEE.ILOHLNLIKDF;
	}

	// Token: 0x06003C57 RID: 15447 RVA: 0x00019467 File Offset: 0x00017667
	private void DPMNBIMDLIM()
	{
		EMENMKHBPQE.NBBKPCKOEPI = base.gameObject;
	}

	// Token: 0x06003C58 RID: 15448 RVA: 0x000194BF File Offset: 0x000176BF
	private void QJLHHQQCIPC(bool IFFGDNBQHLO)
	{
		this.BIIFJOEKNOM = IFFGDNBQHLO;
	}

	// Token: 0x06003C59 RID: 15449 RVA: 0x001C8F30 File Offset: 0x001C7130
	private void NCCBQEIKDNJ()
	{
		if (this.BIIFJOEKNOM && OGJJKKQPNMK.CDDIILFBFCF() != null)
		{
			if (!OGJJKKQPNMK.GGBPGMMCGLI().POQOIMFLCHJ)
			{
				return;
			}
			Ray ray = this.HLFDQLEHQNI.ScreenPointToRay(Input.mousePosition);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 1085f, this.QMOMPLCPFMH))
			{
				if (raycastHit.collider != null)
				{
					if (raycastHit.collider.gameObject && raycastHit.collider.gameObject.tag == "r")
					{
						OGJJKKQPNMK.GGBPGMMCGLI().LFKFEIJFIHC(raycastHit.collider.gameObject);
					}
					else
					{
						OGJJKKQPNMK.CDDIILFBFCF().LFKFEIJFIHC(null);
					}
				}
			}
			else
			{
				OGJJKKQPNMK.QOQONHOOLNE.LFKFEIJFIHC(null);
			}
		}
	}

	// Token: 0x06003C5A RID: 15450 RVA: 0x000194BF File Offset: 0x000176BF
	private void QDOIOMJCCHJ(bool IFFGDNBQHLO)
	{
		this.BIIFJOEKNOM = IFFGDNBQHLO;
	}

	// Token: 0x06003C5B RID: 15451 RVA: 0x001C9000 File Offset: 0x001C7200
	private void KQMMDBBDJQO()
	{
		base.gameObject.transform.NMBPDMIIHJB();
		OQNEQCIKBQJ.CPIJOBOQLOK().QGQDJIENFON();
		GGGPJQEKNJD.HDCHLOLKEGL();
		if (OGJJKKQPNMK.GGBPGMMCGLI() != null)
		{
			if (!OGJJKKQPNMK.GGBPGMMCGLI().POQOIMFLCHJ)
			{
				return;
			}
			Ray ray = this.HLFDQLEHQNI.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 1175f, this.QMOMPLCPFMH) && raycastHit.collider != null && raycastHit.collider.gameObject && raycastHit.collider.gameObject.tag == "gravity")
			{
				OGJJKKQPNMK.QOQONHOOLNE.IEBDBIOKOLC(raycastHit.collider.gameObject);
			}
		}
		if (!GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == 57)
		{
			Ray ray2 = this.PGHJQNJLJKG.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit2;
			if (Physics.Raycast(ray2, out raycastHit2, 1260f, this.LNEIBGCOBGE) && raycastHit2.collider != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>() != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>().IEFBCKQJBGN == null)
			{
				KGQECFKLKOP.LGHLQDLBBIB(raycastHit2.collider.gameObject.GetComponent<JFIBMMBLFDO>().MBPHKDQMJJH);
			}
		}
		if (GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == -1)
		{
			Ray ray3 = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>().ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit3;
			if (Physics.Raycast(ray3, out raycastHit3, 1820f, this.LNEIBGCOBGE) && raycastHit3.collider != null && raycastHit3.collider.gameObject.name == "Battle Request")
			{
				string djinhgfkccg = raycastHit3.collider.transform.parent.GetComponent<QDLMGFQHBJQ>().DJINHGFKCCG;
				KGQECFKLKOP.LGHLQDLBBIB(djinhgfkccg);
			}
		}
	}

	// Token: 0x06003C5C RID: 15452 RVA: 0x001C9230 File Offset: 0x001C7430
	private void ODIGFHJCILQ()
	{
		base.gameObject.transform.NMBPDMIIHJB();
		OQNEQCIKBQJ.QOQONHOOLNE.FFCEMKIQQFQ();
		GGGPJQEKNJD.DHJEEJGJCGE();
		if (OGJJKKQPNMK.GGBPGMMCGLI() != null)
		{
			if (!OGJJKKQPNMK.QOQONHOOLNE.POQOIMFLCHJ)
			{
				return;
			}
			Ray ray = this.HLFDQLEHQNI.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 352f, this.QMOMPLCPFMH) && raycastHit.collider != null && raycastHit.collider.gameObject && raycastHit.collider.gameObject.tag == "The Pokémon summons a hailstorm when it enters a battle.")
			{
				OGJJKKQPNMK.CDDIILFBFCF().IEBDBIOKOLC(raycastHit.collider.gameObject);
			}
		}
		if (!GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == 125)
		{
			Ray ray2 = this.PGHJQNJLJKG.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit2;
			if (Physics.Raycast(ray2, out raycastHit2, 1091f, this.LNEIBGCOBGE) && raycastHit2.collider != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>() != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>().IEFBCKQJBGN == null)
			{
				KGQECFKLKOP.LGHLQDLBBIB(raycastHit2.collider.gameObject.GetComponent<JFIBMMBLFDO>().MBPHKDQMJJH);
			}
		}
		if (GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == -1)
		{
			Ray ray3 = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>().ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit3;
			if (Physics.Raycast(ray3, out raycastHit3, 1486f, this.LNEIBGCOBGE) && raycastHit3.collider != null && raycastHit3.collider.gameObject.name == "(RS)")
			{
				string djinhgfkccg = raycastHit3.collider.transform.parent.GetComponent<QDLMGFQHBJQ>().DJINHGFKCCG;
				KGQECFKLKOP.LGHLQDLBBIB(djinhgfkccg);
			}
		}
	}

	// Token: 0x06003C5D RID: 15453 RVA: 0x00019474 File Offset: 0x00017674
	private void GLNGCMBJQHE(float JDOGIQGGLKM)
	{
		CNCJKLNHQBH.MOGQNGEPCEO().LKHOCPNQIMB = JDOGIQGGLKM;
	}

	// Token: 0x06003C5E RID: 15454 RVA: 0x00019451 File Offset: 0x00017651
	private void DJPBIIKQIIJ(Vector2 JDOGIQGGLKM)
	{
		CNCJKLNHQBH.QOQONHOOLNE.OPMMEOJEBME = EMENMKHBPQE.JHEDGGMDIEE.ILOHLNLIKDF;
	}

	// Token: 0x06003C5F RID: 15455 RVA: 0x000194DE File Offset: 0x000176DE
	private void JCLBDOHFHFQ(float JDOGIQGGLKM)
	{
		CNCJKLNHQBH.QOQONHOOLNE.LKHOCPNQIMB = JDOGIQGGLKM;
	}

	// Token: 0x06003C60 RID: 15456 RVA: 0x000194AB File Offset: 0x000176AB
	private void COIPCKLMFEK(bool IEMBKPKMCGQ)
	{
		if (!IEMBKPKMCGQ)
		{
			CNCJKLNHQBH.BJLGEDCPENQ().OPMMEOJEBME = Vector2.zero;
		}
	}

	// Token: 0x06003C61 RID: 15457 RVA: 0x000194BF File Offset: 0x000176BF
	private void NGDBJMJDDFC(bool IFFGDNBQHLO)
	{
		this.BIIFJOEKNOM = IFFGDNBQHLO;
	}

	// Token: 0x06003C62 RID: 15458 RVA: 0x000194BF File Offset: 0x000176BF
	private void PGFCICOKMDL(bool IFFGDNBQHLO)
	{
		this.BIIFJOEKNOM = IFFGDNBQHLO;
	}

	// Token: 0x06003C63 RID: 15459 RVA: 0x000194AB File Offset: 0x000176AB
	private void QIONBFGBQQN(bool IEMBKPKMCGQ)
	{
		if (!IEMBKPKMCGQ)
		{
			CNCJKLNHQBH.BJLGEDCPENQ().OPMMEOJEBME = Vector2.zero;
		}
	}

	// Token: 0x06003C64 RID: 15460 RVA: 0x00019467 File Offset: 0x00017667
	private void COOEINBIIIE()
	{
		EMENMKHBPQE.NBBKPCKOEPI = base.gameObject;
	}

	// Token: 0x06003C65 RID: 15461 RVA: 0x00019481 File Offset: 0x00017681
	private void PKPMLJLILQP(Vector2 JDOGIQGGLKM)
	{
		CNCJKLNHQBH.BJLGEDCPENQ().OPMMEOJEBME = EMENMKHBPQE.JHEDGGMDIEE.ILOHLNLIKDF;
	}

	// Token: 0x06003C66 RID: 15462 RVA: 0x00019467 File Offset: 0x00017667
	private void JDLQNCEDMPI()
	{
		EMENMKHBPQE.NBBKPCKOEPI = base.gameObject;
	}

	// Token: 0x06003C67 RID: 15463 RVA: 0x001C9460 File Offset: 0x001C7660
	private void ELMMBCJCEOB()
	{
		base.gameObject.transform.NMBPDMIIHJB();
		OQNEQCIKBQJ.QOQONHOOLNE.FFCEMKIQQFQ();
		GGGPJQEKNJD.Hide();
		if (OGJJKKQPNMK.GGBPGMMCGLI() != null)
		{
			if (!OGJJKKQPNMK.QOQONHOOLNE.POQOIMFLCHJ)
			{
				return;
			}
			Ray ray = this.HLFDQLEHQNI.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 1095f, this.QMOMPLCPFMH) && raycastHit.collider != null && raycastHit.collider.gameObject && raycastHit.collider.gameObject.tag == "perishsong")
			{
				OGJJKKQPNMK.GGBPGMMCGLI().IEBDBIOKOLC(raycastHit.collider.gameObject);
			}
		}
		if (!GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == -18)
		{
			Ray ray2 = this.PGHJQNJLJKG.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit2;
			if (Physics.Raycast(ray2, out raycastHit2, 1316f, this.LNEIBGCOBGE) && raycastHit2.collider != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>() != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>().IEFBCKQJBGN == null)
			{
				KGQECFKLKOP.LGHLQDLBBIB(raycastHit2.collider.gameObject.GetComponent<JFIBMMBLFDO>().MBPHKDQMJJH);
			}
		}
		if (GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == -1)
		{
			Ray ray3 = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>().ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit3;
			if (Physics.Raycast(ray3, out raycastHit3, 764f, this.LNEIBGCOBGE) && raycastHit3.collider != null && raycastHit3.collider.gameObject.name == ",")
			{
				string djinhgfkccg = raycastHit3.collider.transform.parent.GetComponent<QDLMGFQHBJQ>().DJINHGFKCCG;
				KGQECFKLKOP.LGHLQDLBBIB(djinhgfkccg);
			}
		}
	}

	// Token: 0x06003C68 RID: 15464 RVA: 0x001C9690 File Offset: 0x001C7890
	private void CFOPEJIQPPF()
	{
		base.gameObject.transform.NMBPDMIIHJB();
		OQNEQCIKBQJ.FHCMDGCONNE().FFCEMKIQQFQ();
		GGGPJQEKNJD.EBGMENEODCD();
		if (OGJJKKQPNMK.CDDIILFBFCF() != null)
		{
			if (!OGJJKKQPNMK.QOQONHOOLNE.POQOIMFLCHJ)
			{
				return;
			}
			Ray ray = this.HLFDQLEHQNI.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 370f, this.QMOMPLCPFMH) && raycastHit.collider != null && raycastHit.collider.gameObject && raycastHit.collider.gameObject.tag == "[/i]")
			{
				OGJJKKQPNMK.GGBPGMMCGLI().IEBDBIOKOLC(raycastHit.collider.gameObject);
			}
		}
		if (!GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == 66)
		{
			Ray ray2 = this.PGHJQNJLJKG.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit2;
			if (Physics.Raycast(ray2, out raycastHit2, 1281f, this.LNEIBGCOBGE) && raycastHit2.collider != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>() != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>().IEFBCKQJBGN == null)
			{
				KGQECFKLKOP.LGHLQDLBBIB(raycastHit2.collider.gameObject.GetComponent<JFIBMMBLFDO>().MBPHKDQMJJH);
			}
		}
		if (GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == -1)
		{
			Ray ray3 = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>().ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit3;
			if (Physics.Raycast(ray3, out raycastHit3, 1884f, this.LNEIBGCOBGE) && raycastHit3.collider != null && raycastHit3.collider.gameObject.name == " cut its own HP and maximized its Attack!\r\n")
			{
				string djinhgfkccg = raycastHit3.collider.transform.parent.GetComponent<QDLMGFQHBJQ>().DJINHGFKCCG;
				KGQECFKLKOP.LGHLQDLBBIB(djinhgfkccg);
			}
		}
	}

	// Token: 0x06003C69 RID: 15465 RVA: 0x000194DE File Offset: 0x000176DE
	private void OnScroll(float JDOGIQGGLKM)
	{
		CNCJKLNHQBH.QOQONHOOLNE.LKHOCPNQIMB = JDOGIQGGLKM;
	}

	// Token: 0x06003C6B RID: 15467 RVA: 0x00019467 File Offset: 0x00017667
	private void Start()
	{
		EMENMKHBPQE.NBBKPCKOEPI = base.gameObject;
	}

	// Token: 0x06003C6C RID: 15468 RVA: 0x00019481 File Offset: 0x00017681
	private void NIECOBNOCEQ(Vector2 JDOGIQGGLKM)
	{
		CNCJKLNHQBH.BJLGEDCPENQ().OPMMEOJEBME = EMENMKHBPQE.JHEDGGMDIEE.ILOHLNLIKDF;
	}

	// Token: 0x06003C6D RID: 15469 RVA: 0x00019474 File Offset: 0x00017674
	private void ILFHCJFGCOC(float JDOGIQGGLKM)
	{
		CNCJKLNHQBH.MOGQNGEPCEO().LKHOCPNQIMB = JDOGIQGGLKM;
	}

	// Token: 0x06003C6E RID: 15470 RVA: 0x000194EB File Offset: 0x000176EB
	private void QGMOLQKFHDE(float JDOGIQGGLKM)
	{
		CNCJKLNHQBH.BJLGEDCPENQ().LKHOCPNQIMB = JDOGIQGGLKM;
	}

	// Token: 0x06003C6F RID: 15471 RVA: 0x001C98C0 File Offset: 0x001C7AC0
	private void LHLLPPOQQIO()
	{
		base.gameObject.transform.NMBPDMIIHJB();
		OQNEQCIKBQJ.FHCMDGCONNE().FFCEMKIQQFQ();
		GGGPJQEKNJD.EBGMENEODCD();
		if (OGJJKKQPNMK.CDDIILFBFCF() != null)
		{
			if (!OGJJKKQPNMK.CDDIILFBFCF().POQOIMFLCHJ)
			{
				return;
			}
			Ray ray = this.HLFDQLEHQNI.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 457f, this.QMOMPLCPFMH) && raycastHit.collider != null && raycastHit.collider.gameObject && raycastHit.collider.gameObject.tag == " melted the ice!\r\n")
			{
				OGJJKKQPNMK.CDDIILFBFCF().QCNFGQHGJDF(raycastHit.collider.gameObject);
			}
		}
		if (!GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == 76)
		{
			Ray ray2 = this.PGHJQNJLJKG.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit2;
			if (Physics.Raycast(ray2, out raycastHit2, 5f, this.LNEIBGCOBGE) && raycastHit2.collider != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>() != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>().IEFBCKQJBGN == null)
			{
				KGQECFKLKOP.LGHLQDLBBIB(raycastHit2.collider.gameObject.GetComponent<JFIBMMBLFDO>().MBPHKDQMJJH);
			}
		}
		if (GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == -1)
		{
			Ray ray3 = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>().ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit3;
			if (Physics.Raycast(ray3, out raycastHit3, 1533f, this.LNEIBGCOBGE) && raycastHit3.collider != null && raycastHit3.collider.gameObject.name == "#")
			{
				string djinhgfkccg = raycastHit3.collider.transform.parent.GetComponent<QDLMGFQHBJQ>().DJINHGFKCCG;
				KGQECFKLKOP.LGHLQDLBBIB(djinhgfkccg);
			}
		}
	}

	// Token: 0x06003C70 RID: 15472 RVA: 0x00019497 File Offset: 0x00017697
	private void OnPress(bool IEMBKPKMCGQ)
	{
		if (!IEMBKPKMCGQ)
		{
			CNCJKLNHQBH.QOQONHOOLNE.OPMMEOJEBME = Vector2.zero;
		}
	}

	// Token: 0x06003C71 RID: 15473 RVA: 0x001C9AF0 File Offset: 0x001C7CF0
	private void CEGPCMGDLBO()
	{
		base.gameObject.transform.NMBPDMIIHJB();
		OQNEQCIKBQJ.FHCMDGCONNE().FFCEMKIQQFQ();
		GGGPJQEKNJD.DHJEEJGJCGE();
		if (OGJJKKQPNMK.CDDIILFBFCF() != null)
		{
			if (!OGJJKKQPNMK.QOQONHOOLNE.POQOIMFLCHJ)
			{
				return;
			}
			Ray ray = this.HLFDQLEHQNI.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 304f, this.QMOMPLCPFMH) && raycastHit.collider != null && raycastHit.collider.gameObject && raycastHit.collider.gameObject.tag == "Icon_Pokemon_Dead")
			{
				OGJJKKQPNMK.GGBPGMMCGLI().QCNFGQHGJDF(raycastHit.collider.gameObject);
			}
		}
		if (!GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == 15)
		{
			Ray ray2 = this.PGHJQNJLJKG.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit2;
			if (Physics.Raycast(ray2, out raycastHit2, 1351f, this.LNEIBGCOBGE) && raycastHit2.collider != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>() != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>().IEFBCKQJBGN == null)
			{
				KGQECFKLKOP.LGHLQDLBBIB(raycastHit2.collider.gameObject.GetComponent<JFIBMMBLFDO>().MBPHKDQMJJH);
			}
		}
		if (GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == -1)
		{
			Ray ray3 = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>().ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit3;
			if (Physics.Raycast(ray3, out raycastHit3, 780f, this.LNEIBGCOBGE) && raycastHit3.collider != null && raycastHit3.collider.gameObject.name == "Hidden/Post FX/Builtin Debug Views")
			{
				string djinhgfkccg = raycastHit3.collider.transform.parent.GetComponent<QDLMGFQHBJQ>().DJINHGFKCCG;
				KGQECFKLKOP.LGHLQDLBBIB(djinhgfkccg);
			}
		}
	}

	// Token: 0x06003C72 RID: 15474 RVA: 0x00019467 File Offset: 0x00017667
	private void KCFPNFCPPCC()
	{
		EMENMKHBPQE.NBBKPCKOEPI = base.gameObject;
	}

	// Token: 0x06003C73 RID: 15475 RVA: 0x001C9D20 File Offset: 0x001C7F20
	private void LMFOGDCKOPH()
	{
		if (this.BIIFJOEKNOM && OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			if (!OGJJKKQPNMK.QOQONHOOLNE.POQOIMFLCHJ)
			{
				return;
			}
			Ray ray = this.HLFDQLEHQNI.ScreenPointToRay(Input.mousePosition);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 1780f, this.QMOMPLCPFMH))
			{
				if (raycastHit.collider != null)
				{
					if (raycastHit.collider.gameObject && raycastHit.collider.gameObject.tag == "ShiftS")
					{
						OGJJKKQPNMK.QOQONHOOLNE.LFKFEIJFIHC(raycastHit.collider.gameObject);
					}
					else
					{
						OGJJKKQPNMK.QOQONHOOLNE.LFKFEIJFIHC(null);
					}
				}
			}
			else
			{
				OGJJKKQPNMK.GGBPGMMCGLI().LFKFEIJFIHC(null);
			}
		}
	}

	// Token: 0x06003C74 RID: 15476 RVA: 0x00019451 File Offset: 0x00017651
	private void QOJEGFIIHLH(Vector2 JDOGIQGGLKM)
	{
		CNCJKLNHQBH.QOQONHOOLNE.OPMMEOJEBME = EMENMKHBPQE.JHEDGGMDIEE.ILOHLNLIKDF;
	}

	// Token: 0x06003C75 RID: 15477 RVA: 0x000194C8 File Offset: 0x000176C8
	private void KFMPDLCIJGE(Vector2 JDOGIQGGLKM)
	{
		CNCJKLNHQBH.MOGQNGEPCEO().OPMMEOJEBME = EMENMKHBPQE.JHEDGGMDIEE.ILOHLNLIKDF;
	}

	// Token: 0x06003C76 RID: 15478 RVA: 0x001C9DF0 File Offset: 0x001C7FF0
	private void DBMBOONLPIL()
	{
		base.gameObject.transform.NMBPDMIIHJB();
		OQNEQCIKBQJ.FHCMDGCONNE().FFCEMKIQQFQ();
		GGGPJQEKNJD.HNMHKIJEDIE();
		if (OGJJKKQPNMK.QOQONHOOLNE != null)
		{
			if (!OGJJKKQPNMK.CDDIILFBFCF().POQOIMFLCHJ)
			{
				return;
			}
			Ray ray = this.HLFDQLEHQNI.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit;
			if (Physics.Raycast(ray, out raycastHit, 1878f, this.QMOMPLCPFMH) && raycastHit.collider != null && raycastHit.collider.gameObject && raycastHit.collider.gameObject.tag == "item: ")
			{
				OGJJKKQPNMK.GGBPGMMCGLI().IEBDBIOKOLC(raycastHit.collider.gameObject);
			}
		}
		if (!GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == 31)
		{
			Ray ray2 = this.PGHJQNJLJKG.ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit2;
			if (Physics.Raycast(ray2, out raycastHit2, 664f, this.LNEIBGCOBGE) && raycastHit2.collider != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>() != null && raycastHit2.collider.gameObject.GetComponent<DJOOHHIQGJK>().IEFBCKQJBGN == null)
			{
				KGQECFKLKOP.LGHLQDLBBIB(raycastHit2.collider.gameObject.GetComponent<JFIBMMBLFDO>().MBPHKDQMJJH);
			}
		}
		if (GGQKBGDGNJN.QOQONHOOLNE.FOHOOGJMFEG && EMENMKHBPQE.JQCODFPLPNJ == -1)
		{
			Ray ray3 = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>().ScreenPointToRay(EMENMKHBPQE.JHEDGGMDIEE.NKKGPNPGDEM);
			RaycastHit raycastHit3;
			if (Physics.Raycast(ray3, out raycastHit3, 1227f, this.LNEIBGCOBGE) && raycastHit3.collider != null && raycastHit3.collider.gameObject.name == "unnerve")
			{
				string djinhgfkccg = raycastHit3.collider.transform.parent.GetComponent<QDLMGFQHBJQ>().DJINHGFKCCG;
				KGQECFKLKOP.LGHLQDLBBIB(djinhgfkccg);
			}
		}
	}

	// Token: 0x06003C77 RID: 15479 RVA: 0x00019474 File Offset: 0x00017674
	private void ENCBNMLNJJK(float JDOGIQGGLKM)
	{
		CNCJKLNHQBH.MOGQNGEPCEO().LKHOCPNQIMB = JDOGIQGGLKM;
	}

	// Token: 0x06003C78 RID: 15480 RVA: 0x00019467 File Offset: 0x00017667
	private void FCOIMQGENDB()
	{
		EMENMKHBPQE.NBBKPCKOEPI = base.gameObject;
	}

	// Token: 0x04000D93 RID: 3475
	public Camera PGHJQNJLJKG;

	// Token: 0x04000D94 RID: 3476
	public Camera HLFDQLEHQNI;

	// Token: 0x04000D95 RID: 3477
	public LayerMask QMOMPLCPFMH;

	// Token: 0x04000D96 RID: 3478
	public LayerMask LNEIBGCOBGE;

	// Token: 0x04000D97 RID: 3479
	private bool BIIFJOEKNOM;
}
