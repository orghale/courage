// ReSharper disable InconsistentNaming

namespace LottoGistAdmin.DataAccess.RemoteManager
{
    public class RemoteEndPoints
    {
        //GAME
        internal const string ADD_GAME_ENDPOINT = "/GistCloud/BasicSettings/AddGame";
        internal const string MODIFY_GAME_ENDPOINT = "/GistCloud/BasicSettings/UpdateGame";
        internal const string DELETE_GAME_ENDPOINT = "/GistCloud/BasicSettings/DeleteGame";
        internal const string LOAD_GAMES_ENDPOINT = "/GistCloud/BasicSettings/LoadGames";

        //OPERATOR
        internal const string ADD_OPERATOR_ENDPOINT = "/GistCloud/BasicSettings/AddOperator";
        internal const string MODIFY_OPERATOR_ENDPOINT = "/GistCloud/BasicSettings/UpdateOperator";
        internal const string DELETE_OPERATOR_ENDPOINT = "/GistCloud/BasicSettings/DeleteOperator";
        internal const string LOAD_OPERATORS_ENDPOINT = "/GistCloud/BasicSettings/LoadOperators";

        //GAME TYPE
        internal const string ADD_GAME_TYPE_ENDPOINT = "/GistCloud/BasicSettings/AddGameType";
        internal const string MODIFY_GAME_TYPE_ENDPOINT = "/GistCloud/BasicSettings/UpdateGameType";
        internal const string DELETE_GAME_TYPE_ENDPOINT = "/GistCloud/BasicSettings/DeleteGameType";
        internal const string LOAD_GAME_TYPES_ENDPOINT = "/GistCloud/BasicSettings/LoadGameTypes";

        //GAME SCHEDULE
        internal const string ADD_GAME_SCHEDULE_ENDPOINT = "/GistCloud/BasicSettings/AddGameSchedule";
        internal const string MODIFY_GAME_SCHEDULE_ENDPOINT = "/GistCloud/BasicSettings/UpdateGameSchedule";
        internal const string DELETE_GAME_SCHEDULE_ENDPOINT = "/GistCloud/BasicSettings/DeleteGameSchedule";
        internal const string LOAD_GAME_SCHEDULES_ENDPOINT = "/GistCloud/BasicSettings/LoadGameSchedules";

        //ECHART
        internal const string ADD_ECHART_ENDPOINT = "/GistCloud/VGist/AddEChart";
        internal const string MODIFY_ECHART_ENDPOINT = "/GistCloud/VGist/UpdateEChart";
        internal const string DELETE_ECHART_ENDPOINT = "/GistCloud/VGist/DeleteEChart";
        internal const string LOAD_ECHARTS_ENDPOINT = "/GistCloud/VGist/LoadECharts";

        //ECHART ITEM
        internal const string ADD_CHART_ITEM_ENDPOINT = "/GistCloud/VGist/AddEChartItem";
        internal const string MODIFY_CHART_ITEM_ENDPOINT = "/GistCloud/VGist/UpdateEChartItem";
        internal const string DELETE_CHART_ITEM_ENDPOINT = "/GistCloud/VGist/DeleteEChartItem";
        internal const string LOAD_CHART_ITEMS_ENDPOINT = "/GistCloud/VGist/LoadEChartItems";

        //CHART SELECTION
        //internal const string ADD_CHART_SELECTION_ENDPOINT = "/GistCloud/VGist/AddChartSelection";
        //internal const string MODIFY_CHART_SELECTION_ENDPOINT = "/GistCloud/VGist/UpdateChartSelection";
        //internal const string DELETE_CHART_SELECTION_ENDPOINT = "/GistCloud/VGist/DeleteChartSelection";
        //internal const string LOAD_CHART_SELECTIONS_ENDPOINT = "/GistCloud/VGist/LoadChartSelections";

        //BLOG CATEGORY
        internal const string ADD_BLOG_CATEGORY_ENDPOINT = "/GistCloud/VGist/AddBlogCategory";
        internal const string MODIFY_BLOG_CATEGORY_ENDPOINT = "/GistCloud/VGist/UpdateBlogCategory";
        //internal const string MODIFY_BLOG_CATEGORY_FREQUENCY_ENDPOINT = "/GistCloud/VGist/UpdateBlogCategoryFrequency";
        internal const string DELETE_BLOG_CATEGORY_ENDPOINT = "/GistCloud/VGist/DeleteBlogCategory";
        internal const string LOAD_BLOG_CATEGORIES_ENDPOINT = "/GistCloud/VGist/LoadBlogCategories";

        //USER
        //internal const string ADD_USER_ENDPOINT = "/GistCloud/VGist/AddUser";
        //internal const string MODIFY_USER_ENDPOINT = "/GistCloud/VGist/UpdateUser";
        //internal const string USER_LOGIN_ENDPOINT = "/Portal/VGist/UserLogin";
        //internal const string LOAD_USERS_ENDPOINT = "/GistCloud/VGist/LoadUsers";

        //BLOG TOPIC
        internal const string ADD_BLOG_TOPIC_ENDPOINT = "/GistCloud/VGist/AddBlogTopic";
        internal const string MODIFY_BLOG_TOPIC_ENDPOINT = "/GistCloud/VGist/UpdateBlogTopic";
        //internal const string MODIFY_BLOG_TOPIC_FREQUENCY_ENDPOINT = "/GistCloud/VGist/UpdateBlogTopicFrequency";
        internal const string DELETE_BLOG_TOPIC_ENDPOINT = "/GistCloud/VGist/DeleteBlogTopic";
        internal const string LOAD_BLOG_TOPICS_ENDPOINT = "/GistCloud/VGist/LoadBlogTopics";

        //BLOG POST
        internal const string ADD_BLOG_POST_ENDPOINT = "/GistCloud/VGist/AddBlogPost";
        internal const string MODIFY_BLOG_POST_ENDPOINT = "/GistCloud/VGist/UpdateBlogPost";
        //internal const string MODIFY_BLOG_POST_FREQUENCY_ENDPOINT = "/GistCloud/VGist/UpdateBlogPostFrequency";
        internal const string DELETE_BLOG_POST_ENDPOINT = "/GistCloud/VGist/DeleteBlogPost";
        internal const string LOAD_BLOG_POSTS_ENDPOINT = "/GistCloud/VGist/LoadBlogPosts";

        //LOTTO SCHOOL
        internal const string ADD_LOTTO_SCHOOL_CATEGORY_ENDPOINT = "/GistCloud/VGist/AddLottoSchoolCategory";
        internal const string UPDATE_LOTTO_SCHOOL_CATEGORY_ENDPOINT = "/GistCloud/VGist/UpdateLottoSchoolCategory";
        internal const string DELETE_LOTTO_SCHOOL_CATEGORY_ENDPOINT = "/GistCloud/VGist/DeleteLottoSchoolCategory";
        internal const string LOAD_LOTTO_SCHOOL_CATEGORIES_ENDPOINT = "/GistCloud/VGist/LoadLottoSchoolCategories";

        //LOOTO SCHOOL TOPIC
        internal const string ADD_LOTTO_SCHOOL_TOPIC_ENDPOINT = "/GistCloud/VGist/AddLottoSchoolTopic";
        internal const string UPDATE_LOTTO_SCHOOL_TOPIC_ENDPOINT = "/GistCloud/VGist/UpdateLottoSchoolTopic";
        internal const string DELETE_LOTTO_SCHOOL_TOPIC__ENDPOINT = "/GistCloud/VGist/DeleteLottoSchoolTopic";
        internal const string LOAD_LOTTO_SCHOOL_TOPICS_ENDPOINT = "/GistCloud/VGist/LoadLottoSchoolTopics";
      
        //LOTTO SCHOOL ITEM
        internal const string ADD_LOTTO_SCHOOL_ITEM_ENDPOINT = "/GistCloud/VGist/AddLottoSchoolItem";
        internal const string UPDATE_LOTTO_SCHOOL_ITEM_ENDPOINT = "/GistCloud/VGist/UpdateLottoSchoolItem";
        internal const string DELETE_LOTTO_SCHOOL_ITEM_ENDPOINT = "/GistCloud/VGist/DeleteLottoSchoolItem";
        internal const string LOAD_LOTTO_SCHOOL_ITEMS_ENDPOINT = "/GistCloud/VGist/LoadLottoSchoolItems";

        //BLOG COMMENT
        //internal const string ADD_BLOG_COMMENT_ENDPOINT = "/GistCloud/VGist/AddBlogComment";
        //internal const string APPROVE_BLOG_COMMENT_ENDPOINT = "/GistCloud/VGist/ApproveBlogComment";
        //internal const string DELETE_BLOG_COMMENT_ENDPOINT = "/GistCloud/VGist/DeleteBlogComment";
        //internal const string LOAD_BLOG_COMMENTS_ENDPOINT = "/GistCloud/VGist/LoadBlogComments";
        //internal const string LOAD_BLOG_COMMENTS_FOR_APPROVAL_ENDPOINT = "/GistCloud/VGist/LoadBlogCommentsForApproval";


        //LOTTO SCHOOL COMMENT
        //internal const string APPROVE_LOTTO_SCHOOL_COMMENT_ENDPOINT = "/GistCloud/VGist/ApproveLottoSchoolComment";
        //internal const string UPDATE_LOTTO_SCHOOL_COMMENT_ENDPOINT = "/GistCloud/VGist/UpdateLottoSchoolComment";
        //internal const string DELETE_LOTTO_SCHOOL_ICOMMENT_ENDPOINT = "/GistCloud/VGist/DeleteLottoSchoolComment";
        internal const string LOAD_LOTTO_SCHOOL_COMMENTS_FOR_APPROVAL_ENDPOINT = "/GistCloud/VGist/LoadLottoSchoolCommentsForApproval";

        //LOTTO FORECAST EXPERT LEVEL
        internal const string ADD_FORECAST_EXPERT_LEVEL_ENDPOINT = "/GistCloud/VGist/AddForecastExpertLevel";
        internal const string UPDATE_FORECAST_EXPERT_LEVEL_ENDPOINT = "/GistCloud/VGist/UpdateForecastExpertLevel";
        internal const string DELETE_FORECAST_EXPERT_LEVEL_ENDPOINT = "/GistCloud/VGist/DeleteForecastExpertLevel";
        internal const string LOAD_FORECAST_EXPERT_LEVELS_ENDPOINT = "/GistCloud/VGist/LoadForecastExpertLevels";

        //LOTTO FORECAST PAD
        internal const string ADD_FORECAST_PAD_ENDPOINT = "/GistCloud/VGist/AddForecastPad";
        internal const string UPDATE_FORECAST_PAD_ENDPOINT = "/GistCloud/VGist/UpdateForecastPad";
        //internal const string DELETE_FORECAST_PAD_ENDPOINT = "/GistCloud/VGist/DeleteForecastExpertLevel";
        internal const string LOAD_FORECAST_PADS_ENDPOINT = "/GistCloud/VGist/LoadForecastPads";

        //LOTTO FORECAST ROOM
        internal const string ADD_FORECAST_ROOM_ENDPOINT = "/GistCloud/VGist/AddForecastRoom";
        internal const string UPDATE_FORECAST_ROOM_ENDPOINT = "/GistCloud/VGist/UpdateForecastRoom";
        internal const string DELETE_FORECAST_ROOM_ENDPOINT = "/GistCloud/VGist/DeleteForecastRoom";
        internal const string LOAD_FORECAST_ROOMS_ENDPOINT = "/GistCloud/VGist/LoadForecastRooms";
    }
}