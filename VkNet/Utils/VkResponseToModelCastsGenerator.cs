// DO NOT EDIT THIS FILE CAUSE ALL CHANGES WILL BE DELETED AUTOMATICALLY

using VkNet.Model;
using VkNet.Model.Attachments;
using VkNet.Model.RequestParams;

namespace VkNet.Utils;

public partial class VkResponse
{
	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator SubjectListItem(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: SubjectListItem.FromJson(response);

	/// <summary>
	/// Разобрать из json.
	/// </summary>
	/// <param name="response"> Ответ сервера. </param>
	/// <returns> </returns>
	public static implicit operator Image(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: Image.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator ShortLink(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: ShortLink.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator Attachment(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: Attachment.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator Education(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: Education.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator Group(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: Group.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator HistoryAttachment(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: HistoryAttachment.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator InformationAboutOffers(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: InformationAboutOffers.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator LastActivity(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: LastActivity.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator LastSeen(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: LastSeen.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator Likes(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: Likes.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator LinkButton(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: LinkButton.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator LinkButtonAction(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: LinkButtonAction.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator LongPollHistoryResponse(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: LongPollHistoryResponse.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator LookupContactsOther(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: LookupContactsOther.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator Lyrics(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: Lyrics.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator Market(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: Market.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator MarketCategory(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: MarketCategory.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator MarketCategorySection(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: MarketCategorySection.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator MarketComment(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: MarketComment.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator MessagesGetObject(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: MessagesGetObject.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator MessagesPushSettings(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: MessagesPushSettings.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator Military(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: Military.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator Occupation(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: Occupation.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator PhotoAlbum(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: PhotoAlbum.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator PhotoSize(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: PhotoSize.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator Place(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: Place.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator PollAnswer(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: PollAnswer.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator PollAnswerVoters(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: PollAnswerVoters.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator PostReach(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: PostReach.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator PostSource(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: PostSource.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator PostView(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: PostView.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator Previews(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: Previews.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator Price(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: Price.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator PushSettings(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: PushSettings.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator Rating(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: Rating.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator Region(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: Region.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator Relative(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: Relative.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator Reposts(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: Reposts.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator School(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: School.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator SchoolClass(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: SchoolClass.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator Street(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: Street.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator Topic(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: Topic.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator University(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: University.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator UploadServerInfo(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: UploadServerInfo.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator User(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: User.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator VideoCatalog(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: VideoCatalog.FromJson(response);

	/// <summary>
	/// Преобразовать из VkResponse
	/// </summary>
	/// <param name="response"> Ответ. </param>
	/// <returns>
	/// Результат преобразования.
	/// </returns>
	public static implicit operator PostDonut(VkResponse response) => response?._token == null || !response._token.HasValues
		? null
		: PostDonut.FromJson(response);
}