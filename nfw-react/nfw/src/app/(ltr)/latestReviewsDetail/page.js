"use client"
import Layout from "@/components/ltr/layout/layout";
import { formatDate } from "@/components/ltr/utils/dateFormatter";
import axios from "axios";
import Link from "next/link";
import { useEffect, useState } from "react";
import StickyBox from "react-sticky-box";

const LatestReviewsDetailPage = ({ id }) => {

  const [latestReviews, setLatestReviews] = useState({})
  useEffect(() => {
    if (id) {
      fetchLatestReviews();
    }
  }, [id]);

  const fetchLatestReviews = async () => {
    try {
      const response = await axios.get(`https://localhost:7272/api/LatestReviews/${id}`);
      setLatestReviews(response.data);
    } catch (error) {
      console.error('Error fetching news', error);
    }
  };

  return (
    <Layout>
      <main className="page_main_wrapper">
        <div className="page-title">
          <div className="container">
            <div className="align-items-center row">
              <div className="col-12 col-sm-auto">
                <nav aria-label="breadcrumb">
                  <ol className="breadcrumb d-inline-block">
                    <li className="breadcrumb-item">
                      <Link href="/">Home</Link>
                    </li>
                    <li className="breadcrumb-item active" aria-current="page">
                      Latest Review Detail
                    </li>
                  </ol>
                </nav>
              </div>
            </div>
          </div>
        </div>
        <div className="container">
          <div className="row row-m">
            <div className="col-md-12 col-p main-content">
              <StickyBox>
                <div className="post_details_inner">
                  <div className="post_details_block">
                    <figure className="social-icon">
                      <img
                        src={latestReviews.latestReviewsImageUrl}
                        className="img-fluid"
                        alt=""
                      />
                    </figure>
                    <h2>
                      {latestReviews.latestReviewsTitle}
                    </h2>
                    <ul className="authar-info d-flex flex-wrap">
                      <li>
                        by {latestReviews.latestReviewsAuthor}
                      </li>
                      <li>{formatDate(latestReviews.latestReviewsTime)}</li>

                    </ul>
                    <p>
                      {latestReviews.latestReviewsDescription}
                    </p>
                  </div>
                </div>
              </StickyBox>
            </div>

          </div>
        </div>
      </main>
    </Layout>
  );
};

export default LatestReviewsDetailPage;