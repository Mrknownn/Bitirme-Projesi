"use client";
import LatestReviewsDetailPage from '../page'

const LatestReviewsDetail = ({ params }) => {


    if (params.id)
        return <LatestReviewsDetailPage id={params.id} />;
};

export default LatestReviewsDetail