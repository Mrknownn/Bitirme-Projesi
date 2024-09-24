import dynamic from "next/dynamic";
import "owl.carousel/dist/assets/owl.carousel.css";
import "owl.carousel/dist/assets/owl.theme.default.css";
import 'animate.css/animate.css'
import { formatDate } from '../utils/dateFormatter';

if (typeof window !== "undefined") {
  window.$ = window.jQuery = require("jquery");
}
// This is for Next.js. On Rect JS remove this line
const OwlCarousel = dynamic(() => import("react-owl-carousel"), {
  ssr: false,
})
const HomeCenterSlider = ({ newsItems }) => {

  const optionEight = {
    loop: true,
    items: 1,
    dots: true,
    animateOut: 'fadeOut',
    animateIn: 'fadeIn',
    autoplay: true,
    autoplayTimeout: 4000, //Set AutoPlay to 4 seconds
    autoplayHoverPause: true,
    nav: true,
    navText: [
      `<i class='ti ti-angle-left'></i>`,
      `<i class='ti ti-angle-right'></i>`
    ]
  }

  const filteredItems = newsItems.filter(item => item.newsID >= 4 && item.newsID <= 8);

  if (newsItems.length > 0)
    return (
      <OwlCarousel id="owl-slider" className="owl-theme" {...optionEight}>
        {filteredItems.map((item) => (
          <div className="item">
            <div className="slider-post post-height-1">
              <a href={`newsDetail/${item.newsID}`} className="news-image">
                <img
                  src={item.newsImageUrl}
                  alt=""
                  className="img-fluid"
                />
              </a>
              <div className="post-text">
                <h2>
                  <a href={`newsDetail/${item.newsID}`}>
                    {item.newsDescription}
                  </a>
                </h2>
                <ul className="align-items-center authar-info d-flex flex-wrap gap-1">
                  <li>
                    By <span className="editor-name">{item.newsAuthor}</span>
                  </li>
                  <li>{item.newsDate ? formatDate(item.newsDate) : '-'}</li>
                </ul>
              </div>
            </div>
          </div>
        ))}
      </OwlCarousel>
    );
};

export default HomeCenterSlider;