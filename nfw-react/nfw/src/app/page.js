"use client"
import StickyBox from "react-sticky-box";
import './globals.css'
import NewsTicker from "@/components/ltr/news-ticker-carousal/page";
import SunnyWeather from "@/components/ltr/sunny-wether/sunny-weather";
import { useBackgroundImageLoader } from "@/components/ltr/use-background-image/use-background-image";
import Layout from "@/components/ltr/layout/layout";
import YoutubeVideo from "@/components/ltr/youtube-video/youtube-video";
import useRemoveBodyClass from "@/components/ltr/useEffect-hook/useEffect-hook";
import HomeFeatureCarousal from "@/components/ltr/home-feature-carousal/home-feature-carousal";
import HomeCenterSlider from "@/components/ltr/home-center-slider/home-center-slider";
import { useEffect, useState } from "react";
import Link from "next/link";
import axios from "axios";
import { formatDate } from "@/components/ltr/utils/dateFormatter";

export default function Home() {

  const iconMap = {
    "01d": "wi-day-sunny",
    "01n": "wi-night-clear",
    "02d": "wi-day-cloudy",
    "02n": "wi-night-alt-cloudy",
    "03d": "wi-cloud",
    "03n": "wi-cloud",
    "04d": "wi-cloudy",
    "04n": "wi-cloudy",
    "09d": "wi-day-showers",
    "09n": "wi-night-showers",
    "10d": "wi-day-rain",
    "10n": "wi-night-rain",
    "11d": "wi-day-thunderstorm",
    "11n": "wi-night-thunderstorm",
    "13d": "wi-day-snow",
    "13n": "wi-night-snow",
    "50d": "wi-day-fog",
    "50n": "wi-night-fog"
  };


  const [newsItems, setNewsItems] = useState([]);
  const [newsItem1, setNewsItem1] = useState({})
  const [newsItem2, setNewsItem2] = useState({})
  const [newsItem3, setNewsItem3] = useState({})
  const [newsItem9, setNewsItem9] = useState({})
  const [newsItem10, setNewsItem10] = useState({})
  const [newsItem11, setNewsItem11] = useState({})
  const [topStories, setTopStories] = useState([])
  const [mostViewed, setMostViewed] = useState([])
  const [midPart, setMidPart] = useState({})
  const [midPart2, setMidPart2] = useState([])
  const [midPart3, setMidPart3] = useState([])
  const [midPart4, setMidPart4] = useState([])
  const [midPart5, setMidPart5] = useState([])
  const [midPart6, setMidPart6] = useState([])
  const [midPart7, setMidPart7] = useState([])
  const [techInnovation, setTechInnovation] = useState({})
  const [techInnovation2, setTechInnovation2] = useState({})
  const [techInnovation3, setTechInnovation3] = useState({})
  const [techInnovation4, setTechInnovation4] = useState({})
  const [editorPicks, setEditorPicks] = useState({})
  const [editorPicks2, setEditorPicks2] = useState({})
  const [editorPicks3, setEditorPicks3] = useState({})
  const [editorPicks4, setEditorPicks4] = useState({})
  const [latestArticles, setLatestArticles] = useState([])
  const [currentWeather, setCurrentWeather] = useState({});
  const [forecast, setForecast] = useState([]);
  const [latestReviews, setLatestReviews] = useState([])
  const [initialVideos, setInitialVideos] = useState([])


  useEffect(() => {
    fetchNews();
    fetchTopStories()
    fetchMostViewed()
    fetchMidPart()
    fetchTechInnovation()
    fetchEditorPicks()
    fetchLatest()
    fetchWeather()
    fetchLatestReviews()
    fetchVideos()
  }, []);


  const fetchVideos = async () => {
    try {
      const response = await axios.get("https://localhost:7272/api/VideoPart");
      setInitialVideos(response.data);
    } catch (error) {
      console.error('Error fetching news', error);
    }
  };

  const fetchWeather = async () => {
    try {
      const url = "http://api.openweathermap.org/data/2.5/weather?lat=38.355362&lon=38.333527&appid=abe2a36e2d7701b30e0c8808105d0a81&units=metric";
      const forecastUrl = "http://api.openweathermap.org/data/2.5/forecast?lat=38.355362&lon=38.333527&appid=abe2a36e2d7701b30e0c8808105d0a81&units=metric";
      const response = await axios.get(url);
      const forecastResponse = await axios.get(forecastUrl);
      setCurrentWeather({
        temp: response.data.main.temp,
        feelsLike: response.data.main.feels_like,
        description: response.data.weather[0].description,
        city: response.data.name
      });

      const filteredForecast = forecastResponse.data.list.filter((item, index, self) =>
        index === self.findIndex((t) => (
          new Date(t.dt * 1000).toDateString() === new Date(item.dt * 1000).toDateString()
        ))
      );

      setForecast(filteredForecast);
    } catch (error) {
      console.error('Error fetching weather', error);
    }
  };

  const fetchEditorPicks = async () => {
    try {
      const response = await axios.get('https://localhost:7272/api/EditorsPicks');
      const editor1 = response.data.find(item => item.editorsPicksID === 1);
      setEditorPicks(editor1);
      const editor2 = response.data.find(item => item.editorsPicksID === 2);
      setEditorPicks2(editor2);
      const editor3 = response.data.find(item => item.editorsPicksID === 3);
      setEditorPicks3(editor3);
      const editor4 = response.data.find(item => item.editorsPicksID === 4);
      setEditorPicks4(editor4);
    } catch (error) {
      console.error('Error fetching editors picks', error);
    }
  };

  const fetchLatestReviews = async () => {
    try {
      const response = await axios.get('https://localhost:7272/api/LatestReviews');
      setLatestReviews(response.data)
    } catch (error) {
      console.error('Error fetching editors picks', error);
    }
  };

  const fetchLatest = async () => {
    try {
      const response = await axios.get('https://localhost:7272/api/LatestArticles');
      setLatestArticles(response.data);
    } catch (error) {
      console.error('Error fetching latest articles', error);
    }
  };

  const fetchTopStories = async () => {
    try {
      const response = await axios.get('https://localhost:7272/api/TopStories');
      setTopStories(response.data);
    } catch (error) {
      console.error('Error fetching top stories', error);
    }
  };

  const fetchTechInnovation = async () => {
    try {
      const response = await axios.get('https://localhost:7272/api/TechandInnovation');
      const innovation1 = response.data.find(item => item.techandInnovationID === 1);
      setTechInnovation(innovation1);
      const innovation2 = response.data.find(item => item.techandInnovationID === 2);
      setTechInnovation2(innovation2);
      const innovation3 = response.data.find(item => item.techandInnovationID === 3);
      setTechInnovation3(innovation3);
      const innovation4 = response.data.find(item => item.techandInnovationID === 4);
      setTechInnovation4(innovation4);
    } catch (error) {
      console.error('Error fetching tech and innovation', error);
    }
  };

  const fetchMostViewed = async () => {
    try {
      const response = await axios.get('https://localhost:7272/api/MostViewed');
      setMostViewed(response.data);
    } catch (error) {
      console.error('Error fetching most viewed', error);
    }
  };

  const fetchMidPart = async () => {
    try {
      const response = await axios.get('https://localhost:7272/api/MidPart');
      const midPartItem1 = response.data.find(item => item.midPartID === 1);
      setMidPart(midPartItem1);
      const midPartItem2 = response.data.find(item => item.midPartID === 2);
      setMidPart2(midPartItem2);
      const midPartItem3 = response.data.find(item => item.midPartID === 3);
      setMidPart3(midPartItem3);
      const midPartItem4 = response.data.find(item => item.midPartID === 4);
      setMidPart4(midPartItem4);
      const midPartItem5 = response.data.find(item => item.midPartID === 5);
      setMidPart5(midPartItem5);
      const midPartItem6 = response.data.find(item => item.midPartID === 6);
      setMidPart6(midPartItem6);
      const midPartItem7 = response.data.find(item => item.midPartID === 7);
      setMidPart7(midPartItem7);

    } catch (error) {
      console.error('Error fetching most mid part', error);
    }
  };


  const fetchNews = async () => {
    try {
      const response = await axios.get('https://localhost:7272/api/News');
      setNewsItems(response.data);
      const newsItemWithIdOne = response.data.find(item => item.newsID === 1);
      setNewsItem1(newsItemWithIdOne)
      const newsItemWithIdTwo = response.data.find(item => item.newsID === 2);
      setNewsItem2(newsItemWithIdTwo)
      const newsItemWithIdThree = response.data.find(item => item.newsID === 3);
      setNewsItem3(newsItemWithIdThree)
      const nine = response.data.find(item => item.newsID === 9);
      setNewsItem9(nine)
      const ten = response.data.find(item => item.newsID === 10);
      setNewsItem10(ten)
      const eleven = response.data.find(item => item.newsID === 11);
      setNewsItem11(eleven)
    } catch (error) {
      console.error('Error fetching news', error);
    }
  };

  useEffect(() => {
    document.documentElement.removeAttribute('dir', 'rtl');
  }, []);

  useRemoveBodyClass(['home-nine'], ['home-six', 'home-seven', 'home-two', 'boxed-layout', 'layout-rtl']);
  useBackgroundImageLoader()
  return (
    <Layout>
      <main className="page_main_wrapper">
        <NewsTicker />
        <div
          className="bg-img feature-section py-4 py-lg-3 py-xl-4"
          data-image-src="assets/images/bg-shape.png"
        >
          <div className="container">
            <HomeFeatureCarousal />
          </div>
        </div>
        <section className="slider-inner">
          <div className="container-fluid p-0">
            <div className="row thm-margin">
              <div className="col-md-4 col-xxl-4 thm-padding d-md-none d-xxl-block">
                <div className="row slider-right-post thm-margin">
                  <div className="col-6 col-sm-6 thm-padding">
                    <div className="slider-post post-height-4">
                      <Link href={`newsDetail/${newsItem1.newsID}`} className="news-image">
                        <img
                          src={newsItem1.newsImageUrl}
                          alt=""
                          className="img-fluid"
                        />
                      </Link>
                      <div className="post-text">
                        <h4>
                          <Link href={`newsDetail/${newsItem1.newsID}`}>
                            {newsItem1.newsDescription}
                          </Link>
                        </h4>
                        <ul className="align-items-center authar-info d-flex flex-wrap gap-1">
                          <li>
                            By <span className="editor-name">{newsItem1.newsAuthor}</span>
                          </li>
                          <li>{newsItem1.newsDate ? formatDate(newsItem1.newsDate) : '-'}</li>
                        </ul>
                      </div>
                    </div>
                  </div>
                  <div className="col-6 col-sm-6 thm-padding">
                    <div className="slider-post post-height-4">
                      <Link href={`newsDetail/${newsItem2.newsID}`} className="news-image">
                        <img
                          src={newsItem2.newsImageUrl}
                          alt=""
                          className="img-fluid"
                        />
                      </Link>
                      <div className="post-text">
                        <h4>
                          <Link href={`newsDetail/${newsItem2.newsID}`}>
                            {newsItem2.newsDescription}
                          </Link>
                        </h4>
                        <ul className="align-items-center authar-info d-flex flex-wrap gap-1">
                          <li>
                            By <span className="editor-name">{newsItem2.newsAuthor}</span>
                          </li>
                          <li>{newsItem2.newsDate ? formatDate(newsItem2.newsDate) : '-'}</li>
                        </ul>
                      </div>
                    </div>
                  </div>
                  <div className="col-md-12 col-sm-12 d-md-block d-none thm-padding">
                    <div className="slider-post post-height-4">
                      <Link href={`newsDetail/${newsItem3.newsID}`} className="news-image">
                        <img
                          src={newsItem3.newsImageUrl}
                          alt=""
                          className="img-fluid"
                        />
                      </Link>
                      <div className="post-text">
                        <h4>
                          <Link href={`newsDetail/${newsItem3.newsID}`}>
                            {newsItem3.newsDescription}
                          </Link>
                        </h4>
                        <ul className="align-items-center authar-info d-flex flex-wrap gap-1">
                          <li>
                            By <span className="editor-name">{newsItem3.newsAuthor}</span>
                          </li>
                          <li>{newsItem3.newsDate ? formatDate(newsItem3.newsDate) : '-'}</li>
                        </ul>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
              <div className="col-md-6 col-xxl-4 thm-padding">
                <div className="slider-wrapper">
                  <HomeCenterSlider newsItems={newsItems} />
                </div>
              </div>
              <div className="col-md-6 col-xxl-4 thm-padding">
                <div className="row slider-right-post thm-margin">
                  <div className="col-md-12 col-sm-12 d-md-block d-none thm-padding">
                    <div className="slider-post post-height-2">
                      <Link href={`newsDetail/${newsItem9.newsID}`} className="news-image">
                        <img
                          src={newsItem9.newsImageUrl}
                          alt=""
                          className="img-fluid"
                        />
                      </Link>
                      <div className="post-text">
                        <h4>
                          <Link href={`newsDetail/${newsItem9.newsID}`}>
                            {newsItem9.newsDescription}
                          </Link>
                        </h4>
                        <ul className="align-items-center authar-info d-flex flex-wrap gap-1">
                          <li>
                            By <span className="editor-name">{newsItem9.newsAuthor}</span>
                          </li>
                          <li>{newsItem9 ? formatDate(newsItem9.newsDate) : '-'}</li>
                        </ul>
                      </div>
                    </div>
                  </div>
                  <div className="col-6 col-sm-6 thm-padding">
                    <div className="slider-post post-height-2">
                      <a href={`newsDetail/${newsItem10.newsID}`} className="news-image">
                        <img
                          src={newsItem10.newsImageUrl}
                          alt=""
                          className="img-fluid"
                        />
                      </a>
                      <div className="post-text">
                        <h4>
                          <a href={`newsDetail/${newsItem10.newsID}`}>
                            {newsItem10.newsDescription}
                          </a>
                        </h4>
                        <ul className="align-items-center authar-info d-flex flex-wrap gap-1">
                          <li>
                            By <span className="editor-name">{newsItem10.newsAuthor}</span>
                          </li>
                          <li>{newsItem10.newsDate ? formatDate(newsItem10.newsDate) : '-'}</li>
                        </ul>
                      </div>
                    </div>
                  </div>
                  <div className="col-6 col-sm-6 thm-padding">
                    <div className="slider-post post-height-2">
                      <a href={`newsDetail/${newsItem11.newsID}`} className="news-image">
                        <img
                          src={newsItem11.newsImageUrl}
                          alt=""
                          className="img-fluid"
                        />
                      </a>
                      <div className="post-text">
                        <h4>
                          <a href={`newsDetail/${newsItem11.newsID}`}>
                            {newsItem11.newsDescription}
                          </a>
                        </h4>
                        <ul className="align-items-center authar-info d-flex flex-wrap gap-1">
                          <li>
                            By <span className="editor-name">{newsItem11.newsAuthor}</span>
                          </li>
                          <li>{newsItem11.newsDate ? formatDate(newsItem11.newsDate) : '-'}</li>
                        </ul>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </section>
        <div className="container">
          <div className="row gx-lg-5">
            <div className="col-md-3 leftSidebar d-none d-xl-block">
              <StickyBox >
                <div className="panel_header">
                  <h4>
                    <strong>Top </strong> Stories
                  </h4>
                </div>
                <div className="border-bottom posts">
                  <ul>{topStories.map((item) => (<li className="post-grid">
                    <div className="posts-inner px-0">
                      <h6 className="posts-title">
                        <a href={`topStoriesDetail/${item.topStoriesID}`}>
                          {item.topStoriesTitle}
                        </a>
                      </h6>
                      <ul className="align-items-center authar-info d-flex flex-wrap gap-1">
                        <li>
                          <span className="post-category">National</span>
                        </li>
                        <li>{item.topStoriesTime ? formatDate(item.topStoriesTime) : '-'}</li>
                      </ul>
                      <p>
                        {item.topStoriesDescription}
                      </p>
                    </div>
                  </li>))}
                  </ul>
                </div>
                {/* START NAV TABS */}
                <div className="tabs-wrapper">
                  <ul className="nav nav-tabs" id="myTab" role="tablist">
                    <li className="nav-item" style={{ display: 'flex', justifyContent: 'center', width: '100%' }} role="presentation">
                      <button
                        className="nav-link border-0 active"
                        id="most-viewed"
                        data-bs-toggle="tab"
                        data-bs-target="#most-viewed-pane"
                        type="button"
                        role="tab"
                        aria-controls="most-viewed-pane"
                        aria-selected="true"
                      >
                        Popular News
                      </button>
                    </li>
                  </ul>
                  <div className="tab-content" id="myTabContent">
                    <div
                      className="tab-pane fade show active"
                      id="most-viewed-pane"
                      role="tabpanel"
                      aria-labelledby="most-viewed"
                      tabIndex={0}
                    >
                      <div className="most-viewed">
                        <ul id="most-today" className="content tabs-content">
                          {mostViewed.map((item) => (<li>
                            <span className="count">0{item.mostViewedID}</span>
                            <span className="text">
                              <a href={`popularNewsDetail/${item.mostViewedID}`}>
                                {item.mostViewedTitle}
                              </a>
                            </span>
                          </li>))}
                        </ul>
                      </div>
                    </div>
                  </div>
                </div>

                {/* END OF /. NAV TABS */}
              </StickyBox>
            </div>
            <div className="col-sm-7 col-md-8 col-xl-6 border-start border-end main-content">
              <StickyBox>
                {/* START POST CATEGORY STYLE ONE (Popular news) */}
                <div className="post-inner">
                  {/* post body */}
                  <div className="post-body py-0">
                    <article>
                      <figure>
                        <a href={`midPartDetail/${midPart.midPartID}`}>
                          <img
                            src={midPart.midPartImageUrl ? midPart.midPartImageUrl : ''}
                            width={345}
                            alt=""
                            className="img-fluid"
                          />
                        </a>
                      </figure>
                      <div className="post-info">
                        <h3 className="fs-4">
                          <a href={`midPartDetail/${midPart.midPartID}`}>
                            {midPart.midPartTitle ? midPart.midPartTitle : ''}
                          </a>
                        </h3>
                        <ul className="align-items-center authar-info d-flex flex-wrap gap-1">
                          <li>
                            <span className="post-category mb-0">Business</span>
                          </li>
                          <li>
                            By <span className="editor-name">{midPart.midPartAuthor ? midPart.midPartAuthor : ''}</span>
                          </li>
                          <li>{midPart.midPartTime ? formatDate(midPart.midPartTime) : '-'}</li>
                        </ul>
                        <p>
                          {midPart.midPartDescription ? midPart.midPartDescription : ''}
                        </p>
                      </div>
                    </article>
                  </div>
                </div>
                <div className="news-grid-2 border-top pt-4 mb-4">
                  <div className="row gx-3 gx-lg-4 gy-4">
                    <div className="col-6 col-md-4 col-sm-6">
                      <div className="grid-item mb-0">
                        <div className="grid-item-img">
                          <a href={`midPartDetail/${midPart2.midPartID}`}>
                            <img
                              src={midPart2.midPartImageUrl ? midPart2.midPartImageUrl : ''}
                              className="img-fluid"
                              alt=""
                            />
                            <div className="link-icon">
                              <i className="fa fa-play" />
                            </div>
                          </a>
                        </div>
                        <h5>
                          <a href={`midPartDetail/${midPart2.midPartID}`} className="title">
                            {midPart2.midPartTitle ? midPart2.midPartTitle : ''}
                          </a>
                        </h5>
                        <ul className="align-items-center authar-info d-flex flex-wrap gap-1 mb-0">
                          <li>{midPart2.midPartTime ? formatDate(midPart2.midPartTime) : ''}</li>
                        </ul>
                      </div>
                    </div>
                    <div className="col-6 col-md-4 col-sm-6">
                      <div className="grid-item mb-0">
                        <div className="grid-item-img">
                          <a href={`midPartDetail/${midPart3.midPartID}`}>
                            <img
                              src={midPart3.midPartImageUrl ? midPart3.midPartImageUrl : ''}
                              className="img-fluid"
                              alt=""
                            />
                            <div className="link-icon">
                              <i className="fa fa-camera" />
                            </div>
                          </a>
                        </div>
                        <h5>
                          <a href={`midPartDetail/${midPart3.midPartID}`} className="title">
                            {midPart3.midPartTitle ? midPart3.midPartTitle : ''}
                          </a>
                        </h5>
                        <ul className="align-items-center authar-info d-flex flex-wrap gap-1 mb-0">
                          <li>{midPart3.midPartTime ? formatDate(midPart3.midPartTime) : ''}</li>
                        </ul>
                      </div>
                    </div>
                    <div className="col-6 col-md-4 col-sm-6">
                      <div className="grid-item mb-0">
                        <div className="grid-item-img">
                          <a href={`midPartDetail/${midPart4.midPartID}`}>
                            <img
                              src={midPart4.midPartImageUrl ? midPart4.midPartImageUrl : ''}
                              className="img-fluid"
                              alt=""
                            />
                            <div className="link-icon">
                              <i className="fa fa-camera" />
                            </div>
                          </a>
                        </div>
                        <h5>
                          <a href={`midPartDetail/${midPart4.midPartID}`} className="title">
                            {midPart4.midPartTitle ? midPart4.midPartTitle : ''}
                          </a>
                        </h5>
                        <ul className="align-items-center authar-info d-flex flex-wrap gap-1 mb-0">
                          <li>{midPart4.midPartTime ? formatDate(midPart4.midPartTime) : ''}</li>
                        </ul>
                      </div>
                    </div>
                    <div className="col-6 col-md-4 col-sm-6">
                      <div className="grid-item mb-0">
                        <div className="grid-item-img">
                          <a href={`midPartDetail/${midPart5.midPartID}`}>
                            <img
                              src={midPart5.midPartImageUrl ? midPart5.midPartImageUrl : ''}
                              className="img-fluid"
                              alt=""
                            />
                            <div className="link-icon">
                              <i className="fa fa-camera" />
                            </div>
                          </a>
                        </div>
                        <h5>
                          <a href={`midPartDetail/${midPart5.midPartID}`} className="title">
                            {midPart5.midPartTitle ? midPart5.midPartTitle : ''}
                          </a>
                        </h5>
                        <ul className="align-items-center authar-info d-flex flex-wrap gap-1 mb-0">
                          <li>{midPart5.midPartTime ? formatDate(midPart5.midPartTime) : ''}</li>
                        </ul>
                      </div>
                    </div>
                    <div className="col-6 col-md-4 col-sm-6">
                      <div className="grid-item mb-0">
                        <div className="grid-item-img">
                          <a href={`midPartDetail/${midPart6.midPartID}`}>
                            <img
                              src={midPart6.midPartImageUrl ? midPart6.midPartImageUrl : ''}
                              className="img-fluid"
                              alt=""
                            />
                            <div className="link-icon">
                              <i className="fa fa-camera" />
                            </div>
                          </a>
                        </div>
                        <h5>
                          <a href={`midPartDetail/${midPart6.midPartID}`} className="title">
                            {midPart6.midPartTitle ? midPart6.midPartTitle : ''}
                          </a>
                        </h5>
                        <ul className="align-items-center authar-info d-flex flex-wrap gap-1 mb-0">
                          <li>{midPart6.midPartTime ? formatDate(midPart6.midPartTime) : ''}</li>
                        </ul>
                      </div>
                    </div>
                    <div className="col-6 col-md-4 col-sm-6">
                      <div className="grid-item mb-0">
                        <div className="grid-item-img">
                          <a href={`midPartDetail/${midPart7.midPartID}`}>
                            <img
                              src={midPart7.midPartImageUrl ? midPart7.midPartImageUrl : ''}
                              className="img-fluid"
                              alt=""
                            />
                            <div className="link-icon">
                              <i className="fa fa-camera" />
                            </div>
                          </a>
                        </div>
                        <h5>
                          <a href={`midPartDetail/${midPart7.midPartID}`} className="title">
                            {midPart7.midPartTitle ? midPart7.midPartTitle : ''}
                          </a>
                        </h5>
                        <ul className="align-items-center authar-info d-flex flex-wrap gap-1 mb-0">
                          <li>{midPart7.midPartTime ? formatDate(midPart7.midPartTime) : ''}</li>
                        </ul>
                      </div>
                    </div>
                  </div>
                </div>

              </StickyBox>
            </div>
            <div className="col-sm-5 col-md-4 col-xl-3 rightSidebar">
              <StickyBox>

                <div className="panel_inner review-inner">
                  <div className="panel_header">
                    <h4>
                      <strong>Latest</strong> Reviews
                    </h4>
                  </div>
                  <div className="panel_body">
                    <div className="news-list">

                      {latestReviews.map((item) => (
                        <div className="news-list-item p-0 mb-4">
                          <div className="img-wrapper">
                            <a href={`latestReviewsDetail/${item.latestReviewsID}`} className="thumb">
                              <img
                                src={item.latestReviewsImageUrl}
                                alt=""
                                className="img-fluid"
                              />
                              <div className="link-icon">
                                <i className="fa fa-camera" />
                              </div>
                            </a>
                          </div>
                          <div className="post-info-2">
                            <h5>
                              <a href={`latestReviewsDetail/${item.latestReviewsID}`} className="title">
                                {item.latestReviewsTitle}
                              </a>
                            </h5>
                          </div>
                        </div>))}
                    </div>
                  </div>
                </div>
                {/* END OF /. LATEST REVIEWS */}
              </StickyBox>
            </div>
            {/* END OF /. SIDE CONTENT */}
          </div>
        </div>
        {/* START YOUTUBE VIDEO */}
        <div className="mb-4 py-5 position-relative video-section">
          <div className="container">
            <div className="row justify-content-center mb-5">
              <div className="col-md-6 text-center">
                <h3 className="text-white">Latest Video News</h3>
                <p className="text-white mb-0">
                  Immerse yourself in the vibrant glow of the city at dusk with 4K Ultra HD 60fps. Experience a virtual journey through stunning urban landscapes, lit by the soft lights of the city. Click play now to start your visual escape and enjoy the best of urban cinematography, always just a click away.
                </p>
              </div>
            </div>
            <YoutubeVideo initialVideos={initialVideos} />
          </div>
        </div>
        {/* END OF /. YOUTUBE VIDEO */}
        <section className="articles-wrapper">
          <div className="container">
            <div className="row gx-lg-5">
              <div className="col-md-3 leftSidebar d-none d-xl-block">
                <StickyBox>
                  {/* START TECH & INNOVATION */}
                  <div className="panel_inner">
                    <div className="panel_header">
                      <h4>
                        <strong>TECH &amp;</strong> INNOVATION
                      </h4>
                    </div>
                    <div className="panel_body">
                      <div className="border-bottom">
                        <a href={`techandInnovationDetail/${techInnovation.techandInnovationID}`} className="d-block mb-3">
                          <img
                            src={techInnovation ? techInnovation.techandInnovationImageUrl : ''}
                            alt=""
                            className="img-fluid w-100"
                          />
                        </a>
                        <h5>
                          <a href={`techandInnovationDetail/${techInnovation.techandInnovationID}`}>
                            {techInnovation ? techInnovation.techandInnovationTitle : ''}
                          </a>
                        </h5>
                        <ul className="align-items-center authar-info d-flex flex-wrap gap-1">
                          <li>
                            <span className="post-category mb-0">EUROPE</span>
                          </li>
                          <li>
                            {techInnovation ? formatDate(techInnovation.techandInnovationTime) : ''}
                          </li>
                        </ul>
                        <p>
                          {techInnovation ? techInnovation.techandInnovationDescription : ''}

                        </p>
                      </div>
                      <div className="border-bottom py-3">
                        <h6 className="posts-title">
                          <a href={`techandInnovationDetail/${techInnovation2.techandInnovationID}`}>
                            {techInnovation2 ? techInnovation2.techandInnovationTitle : ''}
                          </a>
                        </h6>
                        <ul className="align-items-center authar-info d-flex flex-wrap gap-1 mb-0">
                          <li>{techInnovation2 ? formatDate(techInnovation2.techandInnovationTime) : ''}
                          </li>
                        </ul>
                      </div>
                      <div className="border-bottom py-3">
                        <h6 className="posts-title">
                          <a href={`techandInnovationDetail/${techInnovation3.techandInnovationID}`}>
                            {techInnovation3 ? techInnovation3.techandInnovationTitle : ''}
                          </a>
                        </h6>
                        <ul className="align-items-center authar-info d-flex flex-wrap gap-1 mb-0">
                          <li>{techInnovation3 ? formatDate(techInnovation3.techandInnovationTime) : ''}</li>
                        </ul>
                      </div>
                      <div className="py-3 pb-0">
                        <h6 className="posts-title">
                          <a href={`techandInnovationDetail/${techInnovation4.techandInnovationID}`}>
                            {techInnovation4 ? techInnovation4.techandInnovationTitle : ''}
                          </a>
                        </h6>
                        <ul className="align-items-center authar-info d-flex flex-wrap gap-1 mb-0">
                          <li>{techInnovation4 ? formatDate(techInnovation4.techandInnovationTime) : ''}</li>
                        </ul>
                      </div>
                    </div>
                  </div>
                  {/* END OF /. TECH & INNOVATION */}
                  {/* START EDITOR'S PICKS */}

                  {/* END OF /. EDITOR'S PICKS */}
                </StickyBox>
              </div>
              <div className="col-sm-7 col-md-8 col-xl-6 border-start border-end main-content">
                <StickyBox>
                  {/* START POST CATEGORY STYLE FOUR (Latest articles ) */}
                  <div className="post-inner">
                    {/*post header*/}
                    <div className="post-head">
                      <h2 className="title">
                        <strong>Latest</strong> articles
                      </h2>
                    </div>
                    {/* post body */}
                    {latestArticles.map((item) => (
                      <div className="post-body">
                        <div className="news-list-item articles-list">
                          <div className="img-wrapper">
                            <div className="align-items-center bg-primary d-flex justify-content-center position-absolute rounded-circle text-white trending-post z-1">
                              <i className="fa-solid fa-bolt-lightning" />
                            </div>
                            <a href={`latestArticlesDetail/${item.latestArticlesID}`} className="thumb">
                              <img
                                src={item.latestArticlesImageUrl}
                                alt=""
                                className="img-fluid w-100"
                              />
                            </a>
                          </div>
                          <div className="post-info-2">
                            <h4>
                              <a href={`latestArticlesDetail/${item.latestArticlesID}`} className="title">
                                {item.latestArticlesTitle}
                              </a>
                            </h4>
                            <ul className="align-items-center authar-info d-flex flex-wrap gap-1">
                              <li>
                                By <span className="editor-name">{item.latestArticlesAuthor}</span>
                              </li>
                              <li>{formatDate(item.latestArticlesTime)}</li>
                            </ul>
                            <p className="d-lg-block d-none">
                              {item.latestArticlesDescription}
                            </p>
                          </div>
                        </div>
                      </div>))}

                  </div>
                </StickyBox>
              </div>
              <div className="col-sm-5 col-md-4 col-xl-3 rightSidebar">
                <StickyBox>
                  <div className="weather-wrapper-2 weather-bg-2">
                    <div className="weather-temperature">
                      <div className="weather-now">
                        <span className="big-degrees">{Math.round(currentWeather.temp)}</span>
                        <span className="circle">°</span>
                        <span className="weather-unit">C</span>
                      </div>
                      <div className="weather-icon-2">
                        <SunnyWeather />
                      </div>
                    </div>
                    <div className="weather-info">
                      <div className="weather-name">{currentWeather.description}</div>
                      <span>
                        Real Fell: {Math.round(currentWeather.feelsLike)} <sup>°</sup>
                      </span>
                    </div>
                    <div className="weather-week-2">
                      {forecast.map((day, index) => (
                        <div key={index} className="weather-days">
                          <div>{new Date(day.dt * 1000).toLocaleDateString('en-US', { weekday: 'short' })}</div>
                          <div className="day-icon">
                            <i className={`wi ${iconMap[day.weather[0].icon] || 'wi-na'}`}></i>
                          </div>
                          <div className="day-degrees">
                            <span>{Math.round(day.main.temp)}°C</span>
                          </div>
                        </div>
                      ))}
                    </div>
                    <div className="weather-footer">
                      <div className="weather-date">{new Date().toLocaleDateString('en-US', { weekday: 'long', month: 'long', day: 'numeric' })}</div>
                      <div className="weather-city">{currentWeather.city}</div>
                    </div>
                  </div>
                  <div className="archive-wrapper">
                    <div className="panel_inner mb-0">
                      <div className="panel_header">
                        <h4>
                          <strong>EDITOR'S</strong> PICKS
                        </h4>
                      </div>
                      <div className="panel_body">
                        <div className="border-bottom">
                          <a href={`editorPicksDetail/${editorPicks.editorsPicksID}`} className="d-block mb-3">
                            <img
                              src={editorPicks ? editorPicks.editorsPicksImageUrl : ''}
                              alt=""
                              className="img-fluid w-100"
                            />
                          </a>
                          <h5>
                            <a href={`editorPicksDetail/${editorPicks.editorsPicksID}`}>
                              {editorPicks ? editorPicks.editorsPicksTitle : ''}
                            </a>
                          </h5>
                          <ul className="align-items-center authar-info d-flex flex-wrap gap-1">
                            <li>
                              <span className="post-category mb-0">EUROPE</span>
                            </li>
                            <li>
                              {editorPicks ? formatDate(editorPicks.editorsPicksTime) : ''}
                            </li>
                          </ul>
                          <p>
                            {editorPicks ? editorPicks.editorsPicksDescription : ''}

                          </p>
                        </div>
                        <div className="border-bottom py-3">
                          <h6 className="posts-title">
                            <a href={`editorPicksDetail/${editorPicks2.editorsPicksID}`}>
                              {editorPicks2 ? editorPicks2.editorsPicksTitle : ''}
                            </a>
                          </h6>
                          <ul className="align-items-center authar-info d-flex flex-wrap gap-1 mb-0">
                            <li> {editorPicks2 ? formatDate(editorPicks2.editorsPicksTime) : ''}
                            </li>
                          </ul>
                        </div>
                        <div className="border-bottom py-3">
                          <h6 className="posts-title">
                            <a href={`editorPicksDetail/${editorPicks3.editorsPicksID}`}>
                              {editorPicks3 ? editorPicks3.editorsPicksTitle : ''}
                            </a>
                          </h6>
                          <ul className="align-items-center authar-info d-flex flex-wrap gap-1 mb-0">
                            <li> {editorPicks3 ? formatDate(editorPicks3.editorsPicksTime) : ''}
                            </li>
                          </ul>
                        </div>
                        <div className="py-3 pb-0">
                          <h6 className="posts-title">
                            <a href={`editorPicksDetail/${editorPicks4.editorsPicksID}`}>
                              {editorPicks4 ? editorPicks4.editorsPicksTitle : ''}
                            </a>
                          </h6>
                          <ul className="align-items-center authar-info d-flex flex-wrap gap-1 mb-0">
                            <li> {editorPicks4 ? formatDate(editorPicks4.editorsPicksTime) : ''}
                            </li>
                          </ul>
                        </div>
                      </div>
                    </div>
                  </div>
                </StickyBox>
              </div>

            </div>
          </div>
        </section>
      </main>
    </Layout>

  )
}
